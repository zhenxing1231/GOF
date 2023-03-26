namespace GOF._5_FactoryMethod
{
    /// <summary>
    /// 减法工厂类
    /// </summary>
    public class FactorySub : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
