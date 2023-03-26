namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 1号工厂生产的具体产品A
    /// </summary>
    public class ProductA_1 : AbstractProductA
    {
        public int GetFactoryID()
        {
            Console.WriteLine("1号工厂生产的产品A");
            return 1;
        }
    }
}
