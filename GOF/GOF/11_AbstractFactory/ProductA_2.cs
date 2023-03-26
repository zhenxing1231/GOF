namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 2号工厂生产的具体产品A
    /// </summary>
    public class ProductA_2 : AbstractProductA
    {
        public int GetFactoryID()
        {
            Console.WriteLine("2号工厂生产的产品A");
            return 2;
        }
    }
}