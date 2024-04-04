namespace OOP3Belovol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Number num1, num2, result;

                // «читуЇмо числа з текстових пол≥в
                if (radioInteger.Checked)
                {
                    num1 = new Integer(int.Parse(txtNum1.Text));
                    num2 = new Integer(int.Parse(txtNum2.Text));
                }
                else if (radioReal.Checked)
                {
                    num1 = new Real(double.Parse(txtNum1.Text));
                    num2 = new Real(double.Parse(txtNum2.Text));
                }
                else
                {
                    throw new InvalidOperationException("Please select a number type.");
                }

                // ¬иконуЇмо в≥дпов≥дну операц≥ю
                switch (txtOperator.Text)
                {
                    case "+":
                        result = num1.Add(num2);
                        break;
                    case "-":
                        result = num1.Subtract(num2);
                        break;
                    case "*":
                        result = num1.Multiply(num2);
                        break;
                    case "/":
                        result = num1.Divide(num2);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator.");
                }

                // ¬иводимо результат
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
