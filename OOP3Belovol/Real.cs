using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Belovol
{
    public class Real : Number
    {
        private double value;

        public Real(double value)
        {
            this.value = value;
        }

        public override Number Add(Number other)
        {
            return new Real(value + ((Real)other).value);
        }

        public override Number Subtract(Number other)
        {
            return new Real(value - ((Real)other).value);
        }

        public override Number Multiply(Number other)
        {
            return new Real(value * ((Real)other).value);
        }

        public override Number Divide(Number other)
        {
            double divisor = ((Real)other).value;
            if (divisor != 0)
                return new Real(value / divisor);
            else
                throw new DivideByZeroException("Division by zero is not allowed.");
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
