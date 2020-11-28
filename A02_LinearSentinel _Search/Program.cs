using System;

namespace A02_LinearSentinel__Search
{
    class Program
    {
        // Sentinel Linear Search (tìm kiếm tuần tự lính canh)
        static int LinearSentinel(int[] A, int x)
        {
            // Bước 1: Copy và thêm phần tử cần tìm vào cuối mảng
            int[] B = new int[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }
            B[A.Length] = x; // Đặt lính canh

            // Bước 2: So sánh giá trị B[i] với giá trị x 
            for (int j = 0; ; j++)
            {
                if (B[j] == x)
                {
                    return j;
                }
            }
        }

        // Sentinel Linear Search (tìm kiếm tuần tự lính canh)
        static int LinearSentinel_copy(int[] A, int x){
            int n = A.Length;
            int[] B = new int[n + 1];
            Array.Copy(A, B, n);
            B[n] = x;
            int i = 0;
            while (B[i] != x)
                i++;
            if (i == n)
                return -1;
            return i;
        }


        static void Main(string[] args)
        {
            int[] A = new int[32];
            for (int m = 1; m < 32; m++)
            {
                A[m] = m;
            }

            int x = 1;

            int pos = LinearSentinel(A, x);

            //Bước 3: Kiểm tra
            if (pos < A.Length)
            {
                Console.WriteLine("Vi tri cua x trong mang A la:" + pos.ToString());
            }
            else
            {
                Console.WriteLine("i:" + pos.ToString());
                Console.WriteLine("Khong tim thay x");
            }


        }
    }
}
