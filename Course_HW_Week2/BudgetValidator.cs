using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HW_Week2
{
    public static class BudgetValidator
    {
        public static bool DataValidation(string value)
        {
            if (decimal.TryParse(value, out decimal Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
