using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class BrownBear : Mammal
    {
        public override string FurColor { get; set; } = "brown";
        public override int NumLegs { get; set; } = 4;
        public override void Move()
        {
            Console.WriteLine("Move in brownbear class");
        }
        public override int Speak()
        {
            Console.WriteLine("Speak in brownbear class");
            return 99;
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleep in brownbear class");
        }
        public override void Births()
        {
            Console.WriteLine("Births in brownbear class");
        }
        public void EatHoney()
        {
            Console.WriteLine("EatHoney in brownbear class");
        }
    }
}
