
interface IOperation
{
    double Call(params double[] args);
}

public class Operation : IOperation
{

    Func<double[], double> AimFunc;
    
    public Operation(Func<double[], double> aimFunc)
    {
        AimFunc = aimFunc;        
    }

    public double Call(params double[] args)
    {
        return AimFunc(args);      
    }
}

class Program
{
    static void Main()
    {
        var operations = new Dictionary<string, IOperation>(StringComparer.OrdinalIgnoreCase)
        {
            {"+", new Operation(args => args[0]+args[1]) },
            {"-", new Operation(args => args[0]-args[1]) },
            {"*", new Operation(args => args[0]*args[1]) },
            {"/", new Operation(args => args[0]/args[1]) },
            {"sin", new Operation(args => Math.Sin(args[0])) },
            {"cos", new Operation(args => Math.Cos(args[0])) },
            {"tan", new Operation(args => Math.Tan(args[0])) },
            {"asin", new Operation(args => Math.Asin(args[0])) },
            {"acos", new Operation(args => Math.Acos(args[0])) },
            {"atan", new Operation(args => Math.Atan(args[0])) },
            {"atan2", new Operation(args => Math.Atan2(args[0], args[1])) },
            {"sqrt", new Operation(args => Math.Sqrt(args[0])) },
            {"log", new Operation(args => Math.Log(args[0])) },
            {"log10", new Operation(args => Math.Log10(args[0])) },
            {"pow", new Operation(args => Math.Pow(args[0], args[1])) },
            {"abs", new Operation(args => Math.Abs(args[0])) },
            {"pi", new Operation(args => Math.PI)},
            {"e", new Operation(args => Math.E) }
        };

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
