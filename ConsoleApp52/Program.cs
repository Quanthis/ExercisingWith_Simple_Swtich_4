using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {//4.
            int wybor;
            double y, x, ke=4.29, kd=3.81, kf=4.9;
            Console.WriteLine("Program recalculates values in PLN to other currency.");

            do
            {
                Console.WriteLine("1 for BritishFunts");
                Console.WriteLine("2 for AmericanDollars");
                Console.WriteLine("3 for Euro");
                Console.WriteLine("0 to Exit");
            wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.Write("PLN x= ");
                        x = Convert.ToDouble(Console.ReadLine());
                        y =x*kf;  Console.WriteLine("{0} Funts", y);
                        break;
                    case 2:
                        Console.Write("PLN x= ");
                        x = Convert.ToDouble(Console.ReadLine());
                        y = x * kd; Console.WriteLine("{0} $", y);
                        break;
                    case 3:
                        Console.Write("PLN x= ");
                        x = Convert.ToDouble(Console.ReadLine());
                        y = x*ke; Console.WriteLine("{0} Euro", y);
                        break;
                    case 0:
                        break;
                    default: break;
                }
            } while (wybor != 0);
            Console.ReadKey();
        }
    }
}
