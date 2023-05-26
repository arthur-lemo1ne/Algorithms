namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            throw new NotImplementedException();
        }

        private static void MyQuickSort(int[] array, int l, int h)
        {
            if(l>h && array.Length>0)
            {
                int p = partition(array, l, h);
                MyQuickSort(array, l, p - 1);
                MyQuickSort(array, p + 1, h);
            }
        }

        private static int partition(int[] array, int l, int h)
        {
            int pivot = array[h];

            int i = l-1;

            int temp = 0;

            for (int j = l; j <= h-1; j++)
            {
                if(array[j]< pivot)
                {
                    i++;
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }

            temp = array[h];
            array[h] = array[i+1];
            array[i+1] = temp;

            return i + 1;


        }

        public static void QuickSort(int[] array)
        {
            MyQuickSort(array, 0, array.Length-1);
        }

        public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            int position = 0;
            while(position < array.Length)
            {
                if(position == 0 || array[position] >= array[position - 1])
                {
                    position++;
                }
                else
                {
                    int temp = array[position];
                    array[position] = array[position - 1];
                    array[position - 1] = temp;
                    position--;
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
