using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_work
{
    interface IOperation
    {
        double Call(params double[] args);
    }
}
