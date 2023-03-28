using System.Reflection;
namespace GOF._11_AbstractFactory
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //抽象工厂模式 提供一个创建一系列相关或者相互依赖对象的接口，而无需指定它们具体的类
        //进阶技巧，使用反射加抽象工厂来实现通过字符串来控制程序的运行，这里可以将该字符串进行文件读取操作得到，然后实现改配置切换不同的工厂

        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            AdvanceMain();
        }

        private void Main()
        {
            AbstractFactory factory = new ConcreteFactory1();
            //AbstractFactory factory = new ConcreteFactory2();
    
            AbstractProductA productA = factory.CreateProductA();
            AbstractProductB productB = factory.CreateProductB();

            productA.GetFactoryID();
            productB.GetFactoryName();
            Console.Read();
        }

        private void AdvanceMain()
        {
            AbstractFactory factory =
                (AbstractFactory) Assembly.Load("GOF").CreateInstance("GOF._11_AbstractFactory.ConcreteFactory2");
    
            AbstractProductA productA = factory.CreateProductA();
            AbstractProductB productB = factory.CreateProductB();

            productA.GetFactoryID();
            productB.GetFactoryName();
            Console.Read();
        }
    }
}