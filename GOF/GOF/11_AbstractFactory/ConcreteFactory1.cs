namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 具体工厂1号
    /// </summary>
    public class ConcreteFactory1 :AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA_1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB_1();
        }
    }
}
