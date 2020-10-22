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


        static void Main(string[] args)
        {
            int[] A = { 5, 9, 33, 17, 45, 6 };
            int x = 17;

            int pos = LinearSentinel(A, x);

            //Bước 3: Kiểm tra
            if (pos < A.Length)
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
