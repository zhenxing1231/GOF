namespace GOF._5_FactoryMethod
{
    /// <summary>
    /// 乘法法工厂类
    /// </summary>
    public class FactoryMul : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}