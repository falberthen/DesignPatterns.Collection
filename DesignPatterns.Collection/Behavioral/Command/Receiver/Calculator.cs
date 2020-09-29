using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command.Receiver
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Calculator
    {
        private int _currentValue = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _currentValue += operand; break;
                case '-': _currentValue -= operand; break;
                case '*': _currentValue *= operand; break;
                case '/': _currentValue /= operand; break;
            }

            Console.WriteLine("(following {1} {2}) Current value = {0,3}",
              _currentValue, @operator, operand);
        }
    }
}
