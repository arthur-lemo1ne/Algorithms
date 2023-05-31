
namespace AlgorithmsTestProject
{
    public class Stack<T> : IStack<T>
    {

        private List<T> stack;

        public bool IsEmpty { get; set; }

        public Stack()
        {
            stack = new List<T>();
            IsEmpty = true;
        }

        public void Push(T x)
        {
            stack.Add(x);
            if(IsEmpty == true)
            {
                IsEmpty = false;
            }
        }

        public T Pop()
        {
            var ret = stack.Last();
            stack.Remove(ret);
            if(IsEmpty == false && stack.Count == 0)
            {
                IsEmpty = true;
            }
            return ret;
        }

        public T Peek()
        {
            return stack.Last();
        }

    }

    public class Queue<T> : IQueue<T>
    {
        private List<T> queue = new List<T>();

        public void Enqueue(T x)
        {
            queue.Add(x);
        }

        public T Dequeue()
        {
            var ret = queue.First();
            queue.Remove(queue.First());
            return ret;
        }

        public T Peek()
        {
            return queue.First();
        }

        public bool IsEmpty { get; }
    }

    public class PriorityQueue<T> : IPriorityQueue<T>
    {

        private List<(T,int)> pqueue = new List<(T, int)>();

        public void Enqueue(int priority, T element)
        {
            pqueue.Add((element, priority));
        }

        public T PeekHighestPriority()
        {
            (T,int) selected = (default,0);
            foreach (var item in pqueue)
            {
                if(item.Item2 > selected.Item2)
                {
                    selected = item;
                }
            }
            return selected.Item1;
        }

        public T DequeueHighestPriority()
        {
            (T, int) selected = (default, 0);
            foreach (var item in pqueue)
            {
                if (item.Item2 > selected.Item2)
                {
                    selected = item;
                }
            }
            pqueue.Remove(selected);
            return selected.Item1;
        }

        public bool IsEmpty { get; }
    }

    public class QueueFromStack<T> : IQueue<T>
    {
        public readonly Stack<T> S1 = new();
        public readonly Stack<T> S2 = new();

        public void Enqueue(T x)
        {
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty { get; }
    }

    public class StackFromQueue<T> : IStack<T>
    {
        public readonly Queue<T> Q1 = new();
        public readonly Queue<T> Q2 = new();
        public void Push(T x)
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty { get; }
    }
}
