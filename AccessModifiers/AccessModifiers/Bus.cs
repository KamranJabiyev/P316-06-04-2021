using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brend,string model,int passengerCount,string c):base(brend,model,c)
        {
            PassengerCount = passengerCount;
        }

        public void Test()
        {
            
            horsePower = 200;
            Brend = "BMW";
            Console.WriteLine(horsePower);
        }
    }
}
