namespace OOP3Belovol
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
            btnCalculate = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtOperator = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblResult = new Label();
            radioInteger = new RadioButton();
            radioReal = new RadioButton();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(30, 121);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 36);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Результат";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(30, 43);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(392, 43);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(208, 43);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(100, 23);
            txtOperator.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Перше число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 25);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "(+,-,/,*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 25);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Друге число";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 132);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Результат -";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(271, 132);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 8;
            // 
            // radioInteger
            // 
            radioInteger.AutoSize = true;
            radioInteger.Location = new Point(30, 89);
            radioInteger.Name = "radioInteger";
            radioInteger.Size = new Size(223, 19);
            radioInteger.TabIndex = 9;
            radioInteger.TabStop = true;
            radioInteger.Text = "використовувати числа типу Integer";
            radioInteger.UseVisualStyleBackColor = true;
            // 
            // radioReal
            // 
            radioReal.AutoSize = true;
            radioReal.Location = new Point(284, 89);
            radioReal.Name = "radioReal";
            radioReal.Size = new Size(208, 19);
            radioReal.TabIndex = 10;
            radioReal.TabStop = true;
            radioReal.Text = "використовувати числа типу Real";
            radioReal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 211);
            Controls.Add(radioReal);
            Controls.Add(radioInteger);
            Controls.Add(lblResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOperator);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Лабораторна робота №3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtOperator;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblResult;
        private RadioButton radioInteger;
        private RadioButton radioReal;
    }
}
