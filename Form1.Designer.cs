namespace Assignment_4._1._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NumberDisplay = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonClear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonEquals = new Button();
            buttonDecimal = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonNegative = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonSqrt = new Button();
            errorTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NumberDisplay
            // 
            NumberDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NumberDisplay.BackColor = SystemColors.Menu;
            NumberDisplay.Font = new Font("Courier New", 36F, FontStyle.Bold);
            NumberDisplay.ForeColor = SystemColors.ControlText;
            NumberDisplay.Location = new Point(0, 0);
            NumberDisplay.MaxLength = 10;
            NumberDisplay.Name = "NumberDisplay";
            NumberDisplay.PlaceholderText = "0";
            NumberDisplay.ReadOnly = true;
            NumberDisplay.Size = new Size(427, 62);
            NumberDisplay.TabIndex = 0;
            NumberDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(buttonClear, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(button3, 2, 3);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 1);
            tableLayoutPanel1.Controls.Add(button8, 1, 1);
            tableLayoutPanel1.Controls.Add(button9, 2, 1);
            tableLayoutPanel1.Controls.Add(button0, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonEquals, 3, 4);
            tableLayoutPanel1.Controls.Add(buttonDecimal, 2, 4);
            tableLayoutPanel1.Controls.Add(buttonAdd, 3, 3);
            tableLayoutPanel1.Controls.Add(buttonSubtract, 3, 2);
            tableLayoutPanel1.Controls.Add(buttonNegative, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonSqrt, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(427, 344);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClear.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.SetColumnSpan(buttonClear, 2);
            buttonClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(3, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(206, 62);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += PressClear;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 207);
            button1.Name = "button1";
            button1.Size = new Size(100, 62);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Press1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(109, 207);
            button2.Name = "button2";
            button2.Size = new Size(100, 62);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Press2;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(215, 207);
            button3.Name = "button3";
            button3.Size = new Size(100, 62);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Press3;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 139);
            button4.Name = "button4";
            button4.Size = new Size(100, 62);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Press4;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(109, 139);
            button5.Name = "button5";
            button5.Size = new Size(100, 62);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Press5;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(215, 139);
            button6.Name = "button6";
            button6.Size = new Size(100, 62);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Press6;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(3, 71);
            button7.Name = "button7";
            button7.Size = new Size(100, 62);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Press7;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(109, 71);
            button8.Name = "button8";
            button8.Size = new Size(100, 62);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Press8;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(215, 71);
            button9.Name = "button9";
            button9.Size = new Size(100, 62);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Press9;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(109, 275);
            button0.Name = "button0";
            button0.Size = new Size(100, 66);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += Press0;
            // 
            // buttonEquals
            // 
            buttonEquals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEquals.BackColor = SystemColors.ControlDark;
            buttonEquals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEquals.Location = new Point(321, 275);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(103, 66);
            buttonEquals.TabIndex = 10;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += PressEquals;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDecimal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDecimal.Location = new Point(215, 275);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(100, 66);
            buttonDecimal.TabIndex = 11;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += PressDecimal;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(321, 207);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(103, 62);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += PressAdd;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSubtract.BackColor = SystemColors.ControlLight;
            buttonSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubtract.Location = new Point(321, 139);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(103, 62);
            buttonSubtract.TabIndex = 13;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += PressSubtract;
            // 
            // buttonNegative
            // 
            buttonNegative.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonNegative.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNegative.Location = new Point(3, 275);
            buttonNegative.Name = "buttonNegative";
            buttonNegative.Size = new Size(100, 66);
            buttonNegative.TabIndex = 16;
            buttonNegative.Text = "±";
            buttonNegative.UseVisualStyleBackColor = true;
            buttonNegative.Click += pressNegative;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMultiply.BackColor = SystemColors.ControlLight;
            buttonMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(321, 71);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(103, 62);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += PressMultiply;
            // 
            // buttonDivide
            // 
            buttonDivide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDivide.BackColor = SystemColors.ControlLight;
            buttonDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(321, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(103, 62);
            buttonDivide.TabIndex = 15;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += PressDivide;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSqrt.BackColor = SystemColors.ControlLight;
            buttonSqrt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSqrt.Location = new Point(215, 3);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(100, 62);
            buttonSqrt.TabIndex = 19;
            buttonSqrt.Text = "²√";
            buttonSqrt.UseVisualStyleBackColor = false;
            buttonSqrt.Click += PressSqrt;
            // 
            // errorTextBox
            // 
            errorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            errorTextBox.BackColor = SystemColors.Info;
            errorTextBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorTextBox.ForeColor = SystemColors.InfoText;
            errorTextBox.Location = new Point(0, 68);
            errorTextBox.MaxLength = 10;
            errorTextBox.Name = "errorTextBox";
            errorTextBox.ReadOnly = true;
            errorTextBox.Size = new Size(427, 26);
            errorTextBox.TabIndex = 2;
            errorTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 444);
            Controls.Add(errorTextBox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(NumberDisplay);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox NumberDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonEquals;
        private Button buttonDecimal;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonClear;
        private Button buttonNegative;
        private Button buttonSqrt;
        public TextBox errorTextBox;
    }
}
