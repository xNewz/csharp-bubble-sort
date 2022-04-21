using System;

namespace csharp_bubble_sort
{
    class Program
    {
        static int[] bubble_sort(int[] a, int n)
        {
            int tmp;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }

                }
            }
            return a;
        }
        static void Main(string[] args)
        {

        }
    }
}
