using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public class Snake : Reptile
    {
        public string Color { get; set; }
        public override int Move()
        {
            Console.WriteLine("Move in Snake class");
            return 5;
        }
        public override int Speak()
        {
            Console.WriteLine("Speak in Snake class");
            return 25;
        }
    }
}
