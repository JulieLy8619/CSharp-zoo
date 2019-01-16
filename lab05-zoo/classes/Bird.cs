using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Bird : WarmBlooded
    {
        public abstract bool HasFeathers { get; set; }
    }
}
