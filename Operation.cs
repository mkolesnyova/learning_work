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