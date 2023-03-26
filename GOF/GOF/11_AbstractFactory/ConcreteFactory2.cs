namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 具体工厂2号
    /// </summary>
    public class ConcreteFactory2 :AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA_2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB_2();
        }
    }
}