using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Salmon : Fish
    {
        public int NumOfBabies { get; set; }
        public override void Move()
        {
            Console.WriteLine("Move in salmon class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in salmon class");
        }
    }
}
