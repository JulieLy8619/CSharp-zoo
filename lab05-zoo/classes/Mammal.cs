using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class Mammal
    {
        public virtual string FurColor { get; set; }
        public virtual void Births()
        {
            Console.WriteLine("Virtual Birth method in Mammal Class");
        }
    }
}
