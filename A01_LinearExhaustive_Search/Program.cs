using System;

namespace A01_LinearExhaustive_Search
{
    class Program
    {
        // Linear Exhaustive / Sequential search (tìm kiếm tuần tự vét cạn)
        static int LinearExhaustive(int[] A, int x)
        {
            int n = A.Length;

            for (int i = 0; i < n; i++)
            {
                if (A[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] A = { 5, 9, 33, 17, 45, 6 };
            int x = 17;

            int pos = LinearExhaustive(A, x);

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
