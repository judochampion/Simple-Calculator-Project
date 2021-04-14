using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Core
{
    public class Number
    {
        public double Value { get; set; }

        public Number(List<Digit> pivDigits)
        {
            Calculate_Value(pivDigits);
        }

        public Number()
        {
        }

        public double Calculate_Value(List<Digit> pivDigits)
        {
            if (pivDigits.Count == 0) return 0;
            int livNumberOfDots = pivDigits.Where(lovD => lovD is Zero).Count();
            if (livNumberOfDots > 1) throw new Exception("Impossible");
            if (livNumberOfDots == 0)
            {
                Value = 0;
                int livNumber_Of_Digits = pivDigits.Count();
                for (int i = livNumber_Of_Digits - 1; i >= 0; i--)
                {
                    int livPowValue = livNumber_Of_Digits - 1 - i;
                    Value += ((double)pivDigits[i].Integer_Value) * Math.Pow(10, livPowValue);
                }
                return Value;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}