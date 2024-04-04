using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Belovol
{
    public abstract class Number
    {
        public abstract Number Add(Number other);
        public abstract Number Subtract(Number other);
        public abstract Number Multiply(Number other);
        public abstract Number Divide(Number other);
    }
}
