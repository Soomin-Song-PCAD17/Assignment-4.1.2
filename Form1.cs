namespace Assignment_4._1._2
{
    public partial class Form1 : Form
    {
        public Calculator calc = new();
        public Form1()
        {
            InitializeComponent();
            calc.SetDisplay(NumberDisplay);
            //Dictionary<Button, string> buttons = new Dictionary<Button, string>
            //{
            //    { button0, "0" }, { button1, "1" }, { button2, "2" }, { button3, "3" }, { button4, "4" },
            //    { button5, "5" }, { button6, "6" }, { button7, "7" }, { button8, "8" }, { button9, "9" },
            //    { buttonDecimal, "decimal" }, { buttonNegative, "negative" }, { buttonEquals, "equals" },
            //    { buttonAdd, "add" }, { buttonSubtract, "subtract" },
            //    { buttonMultiply, "multiply" }, { buttonDivide, "divide" },
            //    { buttonSqrt, "sqrt" }, { buttonClear, "clear" }, { buttonMemory, "memory" }
            //};
        }


        private void PressNumber(int number)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    // if there's no existing input, set display value
                    calc.OldValue = calc.DisplayDouble;
                    calc.DisplayString = number.ToString();
                    calc.State = Calculator.CalculatorState.InputActiveInteger;
                    calc.UpdateDisplay();
                    break;
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.DisplayString += number.ToString();
                    calc.UpdateDisplay();
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                    // if currently inputting an integer
                    calc.DisplayString += number.ToString();
                    calc.UpdateDisplay();
                    break;
            }
        }
        private void PressDecimal(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.OldValue = calc.DisplayDouble;
                    calc.DisplayString = "0.";
                    calc.State = Calculator.CalculatorState.InputActiveDecimal;
                    calc.UpdateDisplay();
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                    calc.DisplayString += ".";
                    calc.State = Calculator.CalculatorState.InputActiveDecimal;
                    calc.UpdateDisplay();
                    break;
            }
        }
        private void PressClear(object sender, EventArgs e)
        {
            calc.Initialize();
        }



        #region Press Number event handlers
        private void Press0(object sender, EventArgs e) { PressNumber(0); }
        private void Press1(object sender, EventArgs e) { PressNumber(1); }
        private void Press2(object sender, EventArgs e) { PressNumber(2); }
        private void Press3(object sender, EventArgs e) { PressNumber(3); }
        private void Press4(object sender, EventArgs e) { PressNumber(4); }
        private void Press5(object sender, EventArgs e) { PressNumber(5); }
        private void Press6(object sender, EventArgs e) { PressNumber(6); }
        private void Press7(object sender, EventArgs e) { PressNumber(7); }
        private void Press8(object sender, EventArgs e) { PressNumber(8); }
        private void Press9(object sender, EventArgs e) { PressNumber(9); }
        #endregion

        private void PressAdd(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.OldValue = calc.DisplayDouble;
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.PreviousOperation();
                    break;
            }
            calc.LastOp = Calculator.LastOperation.Add;
            calc.UpdateDisplay();
        }

        private void PressSubtract(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.OldValue = calc.DisplayDouble;
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.PreviousOperation();
                    break;
            }
            calc.LastOp = Calculator.LastOperation.Subtract;
            calc.UpdateDisplay();
        }

        private void PressMultiply(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.OldValue = calc.DisplayDouble;
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.PreviousOperation();
                    break;
            }
            calc.LastOp = Calculator.LastOperation.Multiply;
            calc.UpdateDisplay();

        }

        private void PressDivide(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.OldValue = calc.DisplayDouble;
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.PreviousOperation();
                    break;
            }
            calc.LastOp = Calculator.LastOperation.Divide;
            calc.UpdateDisplay();

        }

        private void PressEquals(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.PreviousOperation();
                    break;
            }
        }

        private void PressSqrt(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.DisplayString = Convert.ToString(Math.Sqrt(calc.DisplayDouble));
                    calc.UpdateDisplay();
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.DisplayString = Convert.ToString(Math.Sqrt(calc.DisplayDouble));
                    calc.State = Calculator.CalculatorState.InputReady;
                    calc.UpdateDisplay();
                    break;
            }
        }

        private void pressNegative(object sender, EventArgs e)
        {
            switch (calc.State)
            {
                case Calculator.CalculatorState.InputReady:
                    calc.DisplayDouble = -calc.DisplayDouble;
                    calc.UpdateDisplay();
                    break;
                case Calculator.CalculatorState.InputActiveInteger:
                case Calculator.CalculatorState.InputActiveDecimal:
                    calc.DisplayDouble = -calc.DisplayDouble;
                    calc.UpdateDisplay();
                    break;
            }
        }
    }
}
