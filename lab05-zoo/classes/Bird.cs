using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class Bird : WarmBlooded
    {
        public abstract bool HasFeathers { get; set; }
    }
}
