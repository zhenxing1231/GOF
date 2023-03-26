namespace GOF._5_FactoryMethod
{
    public class OperationSub : Operation
    {
        public override Double GetResult()
        {
            Double result = Arg1 - Arg2;
            return result;
        }
    }
}