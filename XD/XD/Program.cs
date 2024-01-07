using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford= new Car("Ford", "white", 2021, 150);
            Car Opel = new Car("Mercedes", "gray", 2022, 180);
            Car Volvo = new Car("XC-90");
            //Ford.name = "Ford";
            //Ford.year = 2021;
            //Ford.color = "white";
            //Ford.maxSpeed = 150;

            //Opel.name = "Mercedes";
            //Opel.year = 2022;
            //Opel.color = "gray";
            //Opel.maxSpeed = 180;

            Console.WriteLine(Ford.Name);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.Year);
            Console.WriteLine(Ford.engine_type);
            Ford.fullThrottle();
            Ford.honk();

            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Color);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Opel.engine_type);
            Opel.fullThrottle();
            Console.ReadKey();
            Opel.honk();

            Console.WriteLine("Enter Volvo's age: ");
            try
            {
                Volvo.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volvo's age is: " + Volvo.Year);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrottle();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();

        }
    }


}
