﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // a = 696, b = 354, c = 423, d = 957
            //True, False, True, False, True, False
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a < b) & (c > d);
            res[2] = (c > b) || (a == d);
            res[3] = (a < b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a < b) ^ (c == d);

            return res;
        }
    }
}
