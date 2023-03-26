namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 工厂接口
    /// </summary>
    interface AbstractFactory
    {
        AbstractProductA CreateProductA();
        
        AbstractProductB CreateProductB();
    }
}
