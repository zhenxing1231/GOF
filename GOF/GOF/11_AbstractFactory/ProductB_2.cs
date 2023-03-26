namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 2号工厂生产的具体产品B
    /// </summary>
    public class ProductB_2 : AbstractProductB
    {
        public string GetFactoryName()
        {
            Console.WriteLine("2号工厂生产的产品B");
            return "2号工厂";
        }
    }
}