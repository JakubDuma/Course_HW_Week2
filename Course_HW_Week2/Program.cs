
namespace Course_HW_Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BudgetOperationsService service = new BudgetOperationsService();
            OperationsInit(service);
            BudgetService budgetService = new BudgetService();


            Console.WriteLine("Welcome to the Budget Tracker");
            Console.WriteLine("Provide starting budget:");
            decimal balance = decimal.Parse(Console.ReadLine());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose operation:");
                service.DisplayOperations();
                var operation = Console.ReadKey();

                switch (operation.KeyChar)
                {
                    case '1':
                        budgetService.ExpenseAction();
                        break;

                    case '2':
                        budgetService.IncomeAction();
                        break;

                    case '3':
                        budgetService.EditAction();
                        break;

                    case '4':
                        budgetService.DeleteAction();
                        break;

                    case '5':
                        decimal currentBalance = budgetService.CurrentBalance(balance);
                        Console.WriteLine($"\nCurrent balance: {currentBalance}");
                        Console.ReadKey();
                        break;

                    case '6':
                        budgetService.AllEntries();
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static BudgetOperationsService OperationsInit(BudgetOperationsService operations)
        {
            operations.AddOperations(1, "Add expense");
            operations.AddOperations(2, "Add income");
            operations.AddOperations(3, "Edit entry");
            operations.AddOperations(4, "Delete entry");
            operations.AddOperations(5, "Display current budget");
            operations.AddOperations(6, "List all expenses and incomes");
            return operations;
        }
    }
}