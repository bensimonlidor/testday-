using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int m = 2;
            a = Convert.ToInt32(Console.ReadLine());

            while ( a % m !=0)
            {
                m++;
            }
            if ( a==m)
            {
                Console.WriteLine("the num is prime");
            }
            else
            {
                Console.WriteLine(" the num is no prime");
            }
        }
    }
}




B)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int m = 2;
            int sum = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());


            while ( a % m !=0 && b % m != 0 && c % m != 0)
            {
                m++;
            }
            if ( a==m && b==m && c==m)
            {
                Console.WriteLine(sum = a + b + c ); 
            }
            else
            {
                Console.WriteLine(" the num is no prime");
            }
        }
    }
}
