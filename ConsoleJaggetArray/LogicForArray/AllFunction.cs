using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicForArray;

namespace LogicForArray
{
    class AllFunction
    {
        public static int SortMinElem(int[] a, int[] b)
        {
            if (a == null && b == null)
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;
            if (a.Min() > b.Min())
                return 1;
            if (a.Min() < b.Min())
                return -1;
            return 0;
        }
        public static int SortMaxElem(int[] a, int[] b)
        {

            if (a == null && b == null)
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;
            if (a.Max() > b.Max())
                return 1;
            if (a.Max() < b.Max())
                return -1;
            return 0;
        }

        public static int SortMaxSumm(int[] a, int[] b)
        {

            if (a == null && b == null)
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;
            if (a.Sum() > b.Sum())
                return 1;
            if (a.Sum() < b.Sum())
                return -1;
            return 0;
        }
    }
}
