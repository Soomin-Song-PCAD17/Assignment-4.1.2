using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    public class Calculator : ICalculator
    {
        public enum CalculatorState { InputReady, InputActiveInteger, InputActiveDecimal };
        public enum LastOperation { Add, Subtract, Multiply, Divide, Initialize };
        public double DisplayDouble
        {
            get => Convert.ToDouble(DisplayString);
            set => DisplayString = Convert.ToString(value);
        }
        public string DisplayString;
        public double InputValue;
        public double OldValue;
        private TextBox? Display;
        public CalculatorState State;
        public LastOperation LastOp;

        public Calculator(TextBox display)
        {
            Initialize();
            Display = display;
        }
        public Calculator()
        {
            Initialize();
        }

        public void Initialize()
        {
            DisplayString = "0";
            InputValue = 0;
            OldValue = 0;
            State = CalculatorState.InputReady;
            LastOp=LastOperation.Initialize;
            UpdateDisplay();
        }

        public void PreviousOperation()
        {
            switch(LastOp)
            {
                case LastOperation.Add:
                    OldValue = Add(OldValue, DisplayDouble);
                    break;
                case LastOperation.Subtract:
                    OldValue = Subtract(OldValue, DisplayDouble);
                    break;
                case LastOperation.Multiply:
                    OldValue = Multiply(OldValue, DisplayDouble);
                    break;
                case LastOperation.Divide:
                    OldValue = Divide(OldValue, DisplayDouble);
                    break;
                case LastOperation.Initialize:
                    OldValue = DisplayDouble;
                    break;
            }
            State = CalculatorState.InputReady;
            DisplayString = OldValue.ToString();
            UpdateDisplay();
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public void UpdateDisplay()
        {
            if(Display != null)
            {
                Display.Text = DisplayString;
            }
        }
        public void SetDisplay(TextBox display)
        {
            Display = display;
        }
    }
}
