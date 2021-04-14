using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Core.Inputs
{
    public class Equalizer : Input
    {
        public override string Text_Value => "=";

        public override bool Do_Effective_Calculation_If_Last => true;
    }
}