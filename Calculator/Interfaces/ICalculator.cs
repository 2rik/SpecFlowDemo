namespace SpecFlowDemo.Interfaces
{
    public interface ICalculator
    {
        decimal Sum(params decimal[] values);

        decimal Minus(decimal a, decimal b);

        decimal Multiply(decimal a, decimal b);

        decimal Divide(decimal a, decimal b);
    }
}
