using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson3_15
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            const int sizeX = 40;
            const int sizeY = 40;

            if (Math.Abs(x)<sizeX && Math.Abs(y)<sizeY)
            {
                Console.WriteLine("нет");
            }
            else
            {
                if (Math.Abs(x) > sizeX || Math.Abs(y) > sizeY)
                {
                    Console.WriteLine("да");
                }
                else
                {
                    Console.WriteLine("на границе");
                }
            }
            Console.ReadLine();
        }
    }
}
