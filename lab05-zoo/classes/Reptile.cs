using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    public abstract class Reptile : ColdBlooded
    {
        public virtual bool threeChamHeart { get; set; }
        public override bool SelfTempReg { get; set; } = false;
    }
}
