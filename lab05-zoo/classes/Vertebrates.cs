using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class Vertebrates
    {
        public virtual bool HasSpine { get; set; }
        public abstract void Speak();
        public abstract void Move();
    }
}
