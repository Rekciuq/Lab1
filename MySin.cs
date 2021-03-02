using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MySin
    {
        public static int Sin(int x)
        {
            int result = 0;
            string number = Convert.ToString(x);
            foreach (char c in number)
            {
                result += int.Parse(c.ToString());
            }
            return result;
        }

        public static double Sin1(double y)
        {
            double result;
            result = y - (Math.Pow(y, 3) / Factorial(3)) + (Math.Pow(y, 5) / Factorial(5)) - (Math.Pow(y, 7) / Factorial(7)) + (Math.Pow(y, 9) / Factorial(9)) - (Math.Pow(y, 11) / Factorial(11)) + (Math.Pow(y, 13) / Factorial(13));
            return result;
        }
        public static double Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
