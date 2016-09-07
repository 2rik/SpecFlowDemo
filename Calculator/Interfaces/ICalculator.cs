namespace SpecFlowDemo.Interfaces
{
    public interface ICalculator
    {
        double Sum(params double[] values);

        double Minus(double a, double b);

        double Sin(double a);

        double Multiply(params double[] values);

        double Divide(double a, double b);
    }
}
