using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.KonyushevskyAA.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x,4) - Math.Cos(Math.Pow(x,5)) + 3) / (x * x - Math.Sin(x * x) + 12);

                }
                else
                {
                    if ((x > -7) && (x < 0))
                    {
                        
                        y = Math.Pow(1 + (Math.Sqrt(x + 3) / (x * x)), x);

                    }


                    else
                    {
                        if (x < -7)
                        {
                            y = x * x + 10 * x - (1 / x);
                        }



                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
