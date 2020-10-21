using System;

namespace A01_Linear_Search
{
    class Program
    {
        // Linear Exhaustive algorithm (thuật toán vét cạn)
        static int LinearExhaustive(int[] A, int x)
        {   
            // Bước 1: Khởi tạo
            int i = 0;
            int n = A.Length;
            // Bước 2: Kiểm tra
            while (i < n)
            {
                if (A[i] == x)
                {
                    break;
                }

                i++;
            }
            return i;
        }

        // Linear Sentinel algorithm (thuật toán lính canh)
        static int LinearSentinel(int[] A, int x)
        {   
            // Bước 1: Khởi tạo
            int i = 0;

            // Bước 2: Thêm phần tử cần tìm vào cuối mảng
            int[] B =  new int[A.Length + 1]; 
            for( int j = 0; j < A.Length; j++)
            {
                B[j] = A[j];
            }
            B[A.Length] = x;
            // Bước 3: Tìm x
            while (B[i] != x)
            {
                i++;
            }
            return i;

        }


        static void Main(string[] args)
        {
            int[] A = { 5, 9, 33, 17, 45, 6 };
            int x = 17;

            //int pos = LinearExhaustive(A, x);
            int pos = LinearSentinel(A, x);

            if(pos < A.Length)
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
