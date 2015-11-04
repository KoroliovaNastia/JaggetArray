using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForArray
{
    
    public  class Logic
    {
        

        //public static bool CheckMass(int[][] m)
        //{
        //    bool b=true;
        //    if (m == null || m.Length == 0)
        //        b = false;
        //    else{
        //        for (int i = 0; i < m.Length; i++)
        //        {
        //            if (m[i] == null || m[i].Length == 0)
        //                b = false;
        //        }
        //    }
        //    return b;
        //}

        public static void Sort(int[][] m, IComparer<int[]> comparer)
        {
            if (m == null || comparer == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < m.GetLength(0)-1; i++)
            {
                for (int j = i + 1; j < m.GetLength(0); j++)
                {
                    if( comparer.Compare( m[i], m[j] ) > 1)
                        Swap(ref m[i],ref m[j]);
                }
            }
        }

        public static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        
        }

    }
}

