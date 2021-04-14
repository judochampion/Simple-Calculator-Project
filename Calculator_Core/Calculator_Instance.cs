using Calculator_Core.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Calculator_Core
{
    public class Calculator_Instance
    {
        public double Current_Answer { get; set; }

        public List<Input> Current_Situation { get; set; } = new List<Input>();

        public List<Input> Possible_Inputs { get; }

        public void Process(string povInputValue)
        {
            var lovInput = Recognize_Input(povInputValue);
            if (lovInput == null) return;
            Current_Situation.Add(lovInput);
            Process_Current_Situation();
        }

        public Calculator_Instance()
        {
            Possible_Inputs = new List<Input>()
            {
                new One(),
                new Two(),
                new Three(),
                new Four(),
                new Plus(),
                new Minus(),
                new Divide(),
                new Multiply(),
                new Equalizer()
            };
        }

        public Input Recognize_Input(string povInput_Value)
        {
            return Possible_Inputs.Find(lovInput => lovInput.Text_Value == povInput_Value);
        }

        public void Process_Current_Situation()
        {
            if (!Current_Situation.Any()) return;
            if (!Current_Situation.Last().Do_Effective_Calculation_If_Last) return;

            List<Digit> povDigit_List_Current = new List<Digit>();
            Number lovFirst_Argument = new Number();
            Number lovSecond_Argument = new Number();

            Operator lovOperator = new Plus();

            foreach (Input lovInput in Current_Situation)
            {
                if (lovInput is Operator lovOperatorCast)
                {
                    lovOperator = lovOperatorCast;
                    lovFirst_Argument = new Number(povDigit_List_Current);
                    povDigit_List_Current.Clear();
                }
                else if (lovInput is Digit lovDigit)
                {
                    povDigit_List_Current.Add(lovDigit);
                }
                else
                {
                    lovSecond_Argument = new Number(povDigit_List_Current);
                }
            }

            Current_Answer = lovOperator.Operate(lovFirst_Argument.Value, lovSecond_Argument.Value);
            Current_Situation.Clear();
        }
    }
}