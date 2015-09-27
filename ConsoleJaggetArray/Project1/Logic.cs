using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForArray
{
    public static class Logic
    {
        public static void SortMinElem(int[][] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (Logic.MinElem(m[i]) > Logic.MinElem(m[j])) Logic.Swap(ref m[0], ref m[1]);
                }
            }
        }
        public static void SortMaxElem(int[][] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (Logic.MaxElem(m[i]) > Logic.MaxElem(m[j])) Logic.Swap(ref m[i], ref m[j]);
                }
            }
        }

        public static void SortMaxSumm(int[][] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (Logic.Summ(m[i]) < Logic.Summ(m[j])) Logic.Swap(ref m[i], ref m[j]);
                }
            }
        }
        private static int MaxElem(int[] mass)
        {
            int max = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                if (max < mass[i]) max = mass[i];
            }
            return max;
        }
        private static int MinElem(int[] mass)
        {
            int min = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                if (min > mass[i]) min = mass[i];
            }
            return min;
        }
        private static int Summ(int[] mass)
        {
            int sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }
            return sum;
        }

        static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        
        }

    }
}

