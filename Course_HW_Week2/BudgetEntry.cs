using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HW_Week2
{
    public class BudgetEntry
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public ActionType Type { get; set; }
    }


}
