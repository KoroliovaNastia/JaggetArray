using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForArray
{
    class SortMax : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return AllFunction.SortMaxElem(a, b);
        }
    }
}
