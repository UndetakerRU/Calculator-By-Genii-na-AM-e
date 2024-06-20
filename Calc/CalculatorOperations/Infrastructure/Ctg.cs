namespace CalculatorCsharp;

public sealed class Ctg : ICtg
{
    public double Invoke(double num)
    {
        return 1/Math.Tan(num);
    }
}
