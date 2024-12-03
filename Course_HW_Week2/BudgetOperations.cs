using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HW_Week2
{
    public class BudgetOperations
    {
        public int Id { get; set; }
        public string Operation { get; set; }

        public BudgetOperations(int id, string operation)
        {
            Id = id;
            Operation = operation;
        }
    }

}
