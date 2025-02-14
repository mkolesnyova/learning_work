using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ICommon;


namespace learning_work
{
    public class ConsoleCalc
    {
        public Dictionary<string, IOperation> operations;
        public Assembly assem;
        public Type catalogType;

        public ConsoleCalc()
        {
            assem = Assembly.Load("OperationCatalog");
            catalogType = assem.GetType("OperationCatalog.OperationCatalog");

            object catalogObj = Activator.CreateInstance(catalogType);
            PropertyInfo operationsProperty = catalogType.GetProperty("operations");
            operations = (Dictionary<string, IOperation>)operationsProperty.GetValue(catalogObj);              
           
        }

        public void Run()
        {
            try
            {
                Console.Write("Op: ");
                string op = Console.ReadLine();

                if (!operations.ContainsKey(op))
                {
                    throw new Exception("Unkmown operation");
                }

                double[] args = new double[0];
                if (op != "pi" && op != "e")
                {
                    Console.Write("Args: ");
                    string[] input_args = Console.ReadLine().Split(' ');
                    args = Array.ConvertAll(input_args, double.Parse);
                }


                Validation(op, args);
                double result = operations[op].Call(args);
                Console.WriteLine($"Res: {result}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void Validation(string op, double[] args)
        {
            if (op == "/" && args[1] == 0)
                throw new Exception("Division by 0");

            if ((op == "log" || op == "log10") && args[0] <= 0)
                throw new Exception("Logarithm argument must be > 0");

            if (op == "sqrt" && args[0] < 0)
                throw new Exception("Can't calculate sqrt of a negative number");

            if ((op == "pi" || op == "e") && args.Length > 0)
                throw new Exception($"Operation '{op}' doesn't take any arguments");

        }

    }
}
