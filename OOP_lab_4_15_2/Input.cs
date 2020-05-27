using System;
using System.IO;

namespace OOP_lab_4_15_2
{
    class Input
    {
        public static void Read()
        {
            Program.Initialisation(new StreamReader("base.txt").ReadToEnd());
        }

        public static string ReadColor()
        {
            return Console.ReadLine();
        }

        public static string ReadBrand()
        {
            return Console.ReadLine();
        }
    }
}
