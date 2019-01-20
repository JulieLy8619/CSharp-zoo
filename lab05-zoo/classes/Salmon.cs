using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Salmon : Fish
    {
        public int NumOfBabies { get; set; }
        public override int Move()
        {
            Console.WriteLine("Move in salmon class");
            return 4;
        }
        public override int Speak()
        {
            Console.WriteLine("Speak in salmon class");
            return 10;
        }
    }
}
