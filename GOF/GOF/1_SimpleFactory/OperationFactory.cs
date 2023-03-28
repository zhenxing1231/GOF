namespace GOF._1_SimpleFactory
{
    public enum OperationType
    {
        None = 0,
        Add = 1,
        Sub = 2,
        Mul = 3,
        Div = 4,
    }
    /// <summary>
    /// 简单运算工厂
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreateOperation(OperationType Type)
        {
            Operation result = null;
            switch (Type)
            {
                case OperationType.Add:
                    result = new OperationAdd();
                    break;
                case OperationType.Sub:
                    break;
                case OperationType.Mul:
                    break;
                case OperationType.Div:
                    break;
                default:
                    Console.WriteLine($"错误类型! || {Type}");
                    break;
            }

            return result;
        }
    }
}

