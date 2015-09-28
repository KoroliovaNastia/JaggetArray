using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicForArray;

namespace ConsoleJaggetArray
{
    class Program
    {
        static void Show(int[][] a) 
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] {0};
            jaggedArray[1] = new int[] {0};
            jaggedArray[2] = new int[] {0};

            if (Logic.CheckMass(jaggedArray))
            {
                //Logic.SortMaxElem(jaggedArray);
                //Logic.SortMinElem(jaggedArray);
                Logic.SortMaxSumm(jaggedArray);
                Show(jaggedArray);
            }
            else 
            {
                Console.WriteLine("Default mass");
            }
            Console.ReadKey();
        }
    }
}
