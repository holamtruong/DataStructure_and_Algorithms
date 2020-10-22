using System;

namespace A03_Binary_Search
{
    class Program
    {
        // Binary_Search
        static int BinarySearch(int[] A, int x)
        {
            int left = 0;
            int right = A.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;
         
                if (A[mid] == x  )
                {
                    return mid;
                }
                else
                {
                    if (A[mid] > x)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
           

            return -1;
        }

        static void Main(string[] args)
        {
            int[] A = { 1, 2, 6, 26, 28, 37, 40 };
            int x = 40;

            int pos = BinarySearch(A, x);
   
            if (pos != -1)
            {
                Console.WriteLine("Vi tri cua x trong mang A la:" + pos.ToString());
            }
            else
            {
                Console.WriteLine("Khong tim thay x");
            }

        }
    }
}
