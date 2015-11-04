﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicForArray
{
    public class SortMin : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return AllFunction.SortMinElem(a, b);
        }
    }
}
