using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;

        public bool Year { get; internal set; }
        public bool Name { get; internal set; }
        public bool Color { get; internal set; }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            maxSpeed = maxSpeedValue;
            year = yearValue;
        }
        public Car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }
    }
}
