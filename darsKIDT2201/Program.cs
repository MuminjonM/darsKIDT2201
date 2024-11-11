using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darsKIDT2201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 24, b = 36;
            //ekub topish

            
            
            Console.WriteLine("ekub= " + ekub(a,b));
            Console.WriteLine("ekuk= " + ekuk(a, b));

            Console.ReadKey();  

        }

        public static int ekub(int a,int b)
        {

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b = b - a;
            }
            return a;
        }

        public static int ekuk(int a,int b)
        {
            return a*b/ekub(a,b);

        }

    }
}
