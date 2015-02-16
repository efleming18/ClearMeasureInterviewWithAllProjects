using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForClient
{
    public class CustomRule
    {
        public int _denominator;
        public readonly string _output;

        public CustomRule(int denominator, string output)
        {
            _denominator = denominator;
            _output = output;
        }

        public string GetOutput()
        {
            return _output;
        }

        public bool RuleApplies(int currentNumber)
        {
            if (currentNumber % _denominator == 0)
            {
                return true;
            }
            return false;
        }
    }
}
