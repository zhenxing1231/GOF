namespace _1_SimpleFactory
{
    public class OperationAdd : Operation
    {
        public override Double GetResult()
        {
            Double result = Arg1 + Arg2;
            return result;
        }
    }
}