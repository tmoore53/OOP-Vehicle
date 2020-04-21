using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle tylerCar = new Vehicle(make: "Dodge", model: "Challenger");
            Console.WriteLine(tylerCar.Speed);
            tylerCar.Accelerate();
            Console.WriteLine(tylerCar.Speed);

            SportsCar tylerChallenger = new SportsCar();
            Console.WriteLine(tylerChallenger.ColorPaint);
            Console.WriteLine("My Challenger has {0} wheels", tylerChallenger.Wheels);
            Console.WriteLine("My Challenger is going " + tylerChallenger.Speed +"MPH");
            tylerChallenger.Accelerate();
            Console.WriteLine("My Challenger is going " + tylerChallenger.Speed + "MPH");

            Truck myTruck = new Truck();
            Console.WriteLine("My truck has {0} wheels.", myTruck.Wheels);

        }
    }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public int Wheels { get; set; }
        public string ColorPaint { get; set; }
        public int Speed { get; set; }

        #region Constructor
        public Vehicle(string color = "Black", string make = "Sedan", string model = "Sport")
        {
            Make = make;
            Model = model;
            ColorPaint = color;
            Speed = 0;
            Wheels = 4;
        }
        #endregion

        public virtual void Accelerate()
        {
            Speed += 10;
        }
        public void Break()
        {
            Speed -= 15;
            Console.WriteLine("Break Lights");
        }
 
    }
    public class SportsCar : Vehicle
    {
        public override void Accelerate()
        {
            Speed += 30;
        }
    }
    public class Truck: Vehicle
    {
        public Truck(int wheel = 8)
        {
            Wheels = wheel;
        }

        public override void Accelerate()
        {
            Speed += 8;
        }

    }
}
