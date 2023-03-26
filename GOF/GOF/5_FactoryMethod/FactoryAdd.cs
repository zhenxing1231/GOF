namespace GOF._5_FactoryMethod
{
    /// <summary>
    /// 加法工厂类
    /// </summary>
    public class FactoryAdd : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
