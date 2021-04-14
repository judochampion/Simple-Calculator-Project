using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Core
{
    public abstract class Digit : Input
    {
        public int Integer_Value => Convert.ToInt32(Text_Value);
    }

    public class Zero : Digit
    {
        public override string Text_Value { get; } = "0";
    }

    public class One : Digit
    {
        public override string Text_Value { get; } = "1";
    }

    public class Two : Digit
    {
        public override string Text_Value { get; } = "2";
    }

    public class Three : Digit
    {
        public override string Text_Value { get; } = "3";
    }

    public class Four : Digit
    {
        public override string Text_Value { get; } = "4";
    }

    public class Dot : Digit
    {
        public override string Text_Value { get; } = ".";
    }
}