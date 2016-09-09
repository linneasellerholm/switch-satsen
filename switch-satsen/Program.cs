using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_satsen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            Console.WriteLine("Mata in ett heltal");
            int tal = int.Parse(Console.ReadLine());
            switch (tal)
            {
                case 1:
                    Console.WriteLine("Du matade in alternativ 1!");
                    break;
                case 2:
                    Console.WriteLine("Du matade in alternativ 2!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Alternativ 3 och 4 är samma!");
                    break;
                default:
                    Console.WriteLine("Ogiltigt alternativ!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
