namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if(xs.Length != ys.Length) { return false; }
        else
        {
            for (int i = 0; i < xs.Length; i++)
            {
                if (!xs[i].Equals( ys[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {

        if (xs.Length < 2)
        {
            throw new Exception();
        }
        else
        {
            T temp = xs[a];
            xs[a] = xs[b];
            xs[b] = temp;
        }

    }

    public static T FirstElement<T>(T[] xs)
    {
        if(xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[0];
        }
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[xs.Length-1];
        }
    }

    public static T MiddleElement<T>(T[] xs)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[xs.Length/2];
        }
    }

    public static void Reverse<T>(T[] xs)
    {
        for(int i = 0; i < xs.Length / 2; i++)
        {
            var j = xs.Length - i - 1;
            if (i != j)
            {
                T temp = xs[i];
                xs[i] = xs[j];
                xs[j] = temp;
            }
        }
    }

    public static int CountElement<T>(T[] xs, T element)
    { 
        int result = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            if(xs[i].Equals(element))
            {
                result++;
            }
        }
        return result;
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        string result = "";
        for (int i = 0; i < xs.Length; i++)
        {
            if(i < xs.Length - 1)
            {
                result += xs[i] + ",";
            }
            else
            {
                result += xs[i];
            }
        }
        Console.WriteLine(result);
        return result;
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        int result = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            if (predicate(xs[i]))
            {
                result++;
            }
        }
        return result;
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        if(xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            T result = xs[0];
            for (int i = 0; i < xs.Length; i++)
            {
                if(-1 == comparer(xs[i],result))
                {
                    result = xs[i];
                }
            }
            return result;
        }
        
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            T result = xs[0];
            for (int i = 0; i < xs.Length; i++)
            {
                if (1 == comparer(xs[i], result))
                {
                    result = xs[i];
                }
            }
            return result;
        }
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        for (int i = 0; i < xs.Length; i++)
        {
            for (int j = i+1; j < xs.Length; j++)
            {
                if(xs[i].Equals(xs[j]))
                {
                    return false;
                }
            }
        }
        return true;
    }
}