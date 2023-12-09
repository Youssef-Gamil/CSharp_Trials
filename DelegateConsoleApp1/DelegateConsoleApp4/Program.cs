namespace DelegateConsoleApp4
{

  //  delegate void MyDelegate<T>(T[] arr) where T : IComparable<T>;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1, 8, 2, 9, 11 };
            Sort<int>(arr, SelectionSort);
        }

        static void Sort<T>(T[] arr, Action<T[]> m) where T : IComparable<T>
        {
            m(arr);
        }

        static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Console.WriteLine("SelectionSort");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            Console.WriteLine("BubbleSort");
            bool sorted = true;
            int y = 1;
            do
            {
                sorted = true;
                for (int i = 0; i < arr.Length - y; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        sorted = false;
                    }
                }
                y++;
            } while (!sorted);

        }

        static void Swap<T>(ref T obj1, ref T obj2) where T : IComparable<T>
        {
            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

    }
}