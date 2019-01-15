using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    class Peacock : Bird
    {
        public override bool HasFeathers { get; set; } = true;
        public override int NumLegs { get; set; } = 2;
        public string MainColorOfTail { get; set; }
        public override void Move()
        {
            Console.WriteLine("Move in peacock class");
        }
        public override void Speak()
        {
            Console.WriteLine("Speak in peacock class");
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleep in peacock class");
        }
    }
}
