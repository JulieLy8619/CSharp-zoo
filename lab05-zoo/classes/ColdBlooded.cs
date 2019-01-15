using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_zoo.classes
{
    abstract class ColdBlooded : Vertebrates
    {
        public abstract bool SelfTempReg { get; set; }
    }
}
