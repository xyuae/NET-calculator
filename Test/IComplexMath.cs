namespace Test
{
    public interface IComplexMath : IBasicMath
    {
        float EvaluateExpression(string expr);
    }
}