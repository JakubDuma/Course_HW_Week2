using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HW_Week2
{
    public class BudgetOperationsService
    {
        private List<BudgetOperations> Operations = new List<BudgetOperations>();

        public void AddOperations(int id, string operation)
        {
            BudgetOperations budgetOperations = new BudgetOperations(id, operation);
            Operations.Add(budgetOperations);
        }

        public void DisplayOperations()
        {
            foreach (var operation in Operations)
            {
                Console.WriteLine($"{operation.Id}. {operation.Operation}");
            }
        }
    }
}