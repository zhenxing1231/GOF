namespace GOF._3_Decorator
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //装饰模式 可以动态的给一个对象添加新的职能。
        //个人理解为一种套娃或者是串联的形式，是一个非常实用的模式，可以用来写Buff系统等重要功能。

        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();
            FinalDecorator finalDecorator = new FinalDecorator();
    
            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);
            finalDecorator.SetComponent(decoratorB);
    
            finalDecorator.Opreation();

            Console.Read();
        }
    }
}