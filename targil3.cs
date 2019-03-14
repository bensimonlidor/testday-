using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a=7; a>=1; a--)
            {
                for (int i = 1; i < a; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
