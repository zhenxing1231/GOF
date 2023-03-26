namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 1号工厂生产的具体产品B
    /// </summary>
    public class ProductB_1 : AbstractProductB
    {
        public string GetFactoryName()
        {
            Console.WriteLine("1号工厂生产的产品B");
            return "1号工厂";
        }
    }
}