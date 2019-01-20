using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Vertebrates
    {
        public virtual bool HasSpine { get; set; } = true;
        public abstract int Speak();
        public abstract void Move();
    }
}
