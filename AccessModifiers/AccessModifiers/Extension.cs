using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    //all static class members must be static, can't get instance, can't get inheretance
    public static class Extension
    {
        static Extension()
        {
            Console.WriteLine("Extension");
        }

        public static int MyProperty;

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
