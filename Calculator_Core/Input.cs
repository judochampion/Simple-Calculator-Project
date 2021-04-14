using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Core
{
    public abstract class Input
    {
        public abstract string Text_Value { get; }
        public virtual bool Do_Effective_Calculation_If_Last => false;
    }
}