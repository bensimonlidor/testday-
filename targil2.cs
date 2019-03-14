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
            int secondsTotal = Convert.ToInt32(Console.ReadLine());
           
        if(secondsTotal >= 0)
            {
                Console.WriteLine("secondsTotal is value");
            }
        else
            {
                Console.WriteLine("error");
            }

            int days = secondsTotal / (60 * 60 * 24);
            secondsTotal = secondsTotal % (60 * 60 * 24);

            int hours = secondsTotal / (60*60);
            secondsTotal = secondsTotal % (60*60);

            int minutes = secondsTotal / 60;
            secondsTotal = secondsTotal % 60;

            int seconds = secondsTotal / 1;
            secondsTotal = secondsTotal % 1;

            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(seconds);

        }
    }
}
