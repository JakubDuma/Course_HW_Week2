
namespace Course_HW_Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BudgetOperationsService service = new BudgetOperationsService();
            OperationsInit(service);
            BudgetService budgetService = new BudgetService();


            Console.WriteLine("Welcome to the spending tracker");
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
                        balance -= budgetService.ExpenseAction();
                        break;

                    case '2':
                        balance += budgetService.IncomeAction();
                        break;

                    case '3':
                        Console.WriteLine($"\nCurrent balance: {balance}");
                        Console.ReadKey();
                        break;

                    case '4':
                        budgetService.AllOperations();
                        Console.ReadKey();
                        break;
                }
            }

        }


        private static BudgetOperationsService OperationsInit(BudgetOperationsService operations)
        {
            operations.AddOperations(1, "Add expense");
            operations.AddOperations(2, "Add income");
            operations.AddOperations(3, "Display current budget");
            operations.AddOperations(4, "List all expenses and incomes");
            return operations;
        }
    }
}