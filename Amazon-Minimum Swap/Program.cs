using System;

namespace Amazon_Minimum_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 1, 3, 2, 4, 5, 6 };
            Console.WriteLine(MinimumSwap(arr));
        }

        static int MinimumSwap(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != i + 1)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if(arr[j] != j+1)
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            min++;
                            break;
                        }
                    }
                }
            }

            return min;
        }

    }
}
