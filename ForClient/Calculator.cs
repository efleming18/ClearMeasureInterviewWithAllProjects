using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForClient
{
    public class Calculator
    {
        private List<CustomRule> _customRules;
        public Calculator(List<CustomRule> customRules)
        {
            _customRules = customRules;
        }

        public string ResultGivenInputOf(int currentNumber)
        {
            var resultToReturn = "";
            foreach (var rule in _customRules)
            {
                if (rule.RuleApplies(currentNumber))
                {
                    resultToReturn += rule.GetOutput();
                }
            }
            if (resultToReturn != "")
            {
                return resultToReturn;
            }
            return currentNumber.ToString();
        }
    }
}
