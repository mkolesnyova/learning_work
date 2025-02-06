using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_work
{
    public class OperationsCatalog
    {
        public Dictionary<string, IOperation> operations { get; set; }

        public OperationsCatalog() 
        {
            operations = new Dictionary<string, IOperation>(StringComparer.OrdinalIgnoreCase)
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

        }
        
    }
}
