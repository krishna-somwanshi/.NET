using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total Batches");
            int Batch = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[Batch][];
            for (int i = 0; i < Batch; i++)
            {
                Console.WriteLine("Emter Batch Size");
                int BatchSize = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[BatchSize];
            }


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Enter Marks [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Student Marks {0},{1} is {2}  ", i, j, arr[i][j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
