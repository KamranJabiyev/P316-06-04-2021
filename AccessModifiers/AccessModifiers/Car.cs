using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Car
    {
        //property
        public int Id { get;  }
        public string Model { get; set; }
        public string Brend { get; set; }
        private string Color;
        private int speed;
        protected int horsePower;
        public readonly int Price=50000;
        private readonly string _type="sedan";

        //ENCAPSULATION
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 10 && value <= 400)
                {
                    speed = value;
                    Console.WriteLine("Ok");
                    return;
                }
                Console.WriteLine("Please enter correct speed");
            }
        }

        //public void SetSpeed(int speed)
        //{
        //    if(speed>10&& speed <= 400)
        //    {
        //        this.speed = speed;
        //        Console.WriteLine("Ok");
        //        return;
        //    }
        //    Console.WriteLine("Please enter correct speed");
        //}

        //public int GetSpeed()
        //{
        //    return speed;
        //}

        public Car()
        {
            Id = 5;
            _type = "offroad";
            Price = 100000;
            Console.WriteLine("Car created");
        }

        public Car(string brend,string model,string color)
        {
            Brend = brend;
            Model = model;
            Color = color;
        }

        private void Info()
        {
            horsePower = 2;
            Color = "Red";
            Console.WriteLine(Price);
        }
    }
}

namespace Demo2.DemoInDemo2
{
    class Test
    {
        public int MyProperty { get; set; }
    }
}
