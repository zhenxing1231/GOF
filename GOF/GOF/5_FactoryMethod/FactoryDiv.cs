namespace GOF._5_FactoryMethod
{
    /// <summary>
    /// 除法工厂类
    /// </summary>
    public class FactoryDiv : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}