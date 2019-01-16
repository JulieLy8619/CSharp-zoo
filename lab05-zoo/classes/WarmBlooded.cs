using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class WarmBlooded : Vertebrates
    {
        public virtual int NumLegs { get; set; }
        public virtual void Sleep()
        {
            Console.WriteLine("Virtual Sleep method in WarmBlood Class");
        }
    }
}
