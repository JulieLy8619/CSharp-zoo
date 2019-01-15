using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class Fish : ColdBlooded
    {
        public virtual bool OnlyLiveInWater { get; set; }
        public override bool SelfTempReg { get; set; } = false;
    }
}
