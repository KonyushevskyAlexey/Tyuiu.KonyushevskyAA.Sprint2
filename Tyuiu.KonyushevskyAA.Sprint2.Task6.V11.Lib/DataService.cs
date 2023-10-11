using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n < 31)
                    {
                        return n++.ToString();
                    }
                    else
                    {
                        return m++.ToString();
                    }

                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < 30)
                    {
                        m++;
                        return Convert.ToString(m);
                    }
                    else
                    {
                        m++;
                        return Convert.ToString(m); 
                    }

                case 12:
                    if (n < 31)
                    {
                        n++;
                        return Convert.ToString(n);
                    }
                    else
                    {
                        g++;
                        return Convert.ToString(g);
                    }

                default:
                    if (n < 28)
                    {
                        n++;
                        return Convert.ToString(n);
                    }
                    else
                    {
                        // Новый месяц m
                        m++;
                        return  Convert.ToString(m);
                    }

                  

            }
        }
    }
}
