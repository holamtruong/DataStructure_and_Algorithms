using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A04_Selection_Sort
{
    class Program
    {
        static void SelectionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                // Di tim phan tu nho nhat thu i de dua ve vi tri i
                int minIndex = i;
                for (int j = i; j < n; j++)
                {
                    if (a[minIndex] > a[j])
                        minIndex = j;
                }
                // Da tim duoc phan tu nho nhat, hoan vi ve vi tri i
                if (minIndex != i)
                {
                    int temp = a[minIndex];
                    a[minIndex] = a[i];
                    a[i] = temp;
                }
                PrintArray(a);
            }
         
        }

        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i].ToString() + " ");
            Console.WriteLine("");
        }
        static int[] ReadArray()
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                a[i] = int.Parse(s);
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = { 26, 48, 12, 92, 28, 6, 33 };
            //Console.WriteLine("Input:");
            //PrintArray(a); // 564 15 37 89 100 46
            SelectionSort(a);
            //Console.WriteLine("Output:");
            PrintArray(a); // 15 37 46 89 100 564
        }
    }
}
