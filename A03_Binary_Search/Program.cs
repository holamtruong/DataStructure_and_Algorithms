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
                       // Console.WriteLine("right: " + right.ToString());
                    }
                    else
                    {
                        left = mid + 1;
                       // Console.WriteLine("left: " + left.ToString());
                    }
                }
                Console.WriteLine("right: " + right.ToString());
                Console.WriteLine("left: " + left.ToString());
            }
           

            return -1;
        }

        static void Main(string[] args)
        {
            int[] A = { 5, 11, 25, 28, 45, 78, 100, 120, 125 };
            int x = 110;

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
