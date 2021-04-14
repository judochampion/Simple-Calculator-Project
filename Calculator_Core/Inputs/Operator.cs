using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Core
{
    public abstract class Operator : Input
    {
        public abstract double Operate(double First_Argument, double Second_Argument);
    }

    public class Plus : Operator
    {
        public override string Text_Value => "+";

        public override double Operate(double First_Argument, double Second_Argument)
        {
            return First_Argument + Second_Argument;
        }
    }

    public class Minus : Operator
    {
        public override string Text_Value => "-";

        public override double Operate(double First_Argument, double Second_Argument)
        {
            return First_Argument - Second_Argument;
        }
    }

    public class Divide : Operator
    {
        public override string Text_Value => "/";

        public override double Operate(double First_Argument, double Second_Argument)
        {
            return First_Argument / Second_Argument;
        }
    }

    public class Multiply : Operator
    {
        public override string Text_Value => "*";

        public override double Operate(double First_Argument, double Second_Argument)
        {
            return First_Argument * Second_Argument;
        }
    }
}