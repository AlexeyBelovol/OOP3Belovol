using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Belovol
{
    public class Integer : Number
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }

        public override Number Add(Number other)
        {
            return new Integer(value + ((Integer)other).value);
        }

        public override Number Subtract(Number other)
        {
            return new Integer(value - ((Integer)other).value);
        }

        public override Number Multiply(Number other)
        {
            return new Integer(value * ((Integer)other).value);
        }

        public override Number Divide(Number other)
        {
            int divisor = ((Integer)other).value;
            if (divisor != 0)
                return new Integer(value / divisor);
            else
                throw new DivideByZeroException("Division by zero is not allowed.");
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
