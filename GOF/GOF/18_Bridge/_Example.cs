namespace GOF._18_Bridge
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //桥接模式可以将抽象部分和实现部分分离，这个实现是指抽象类和它的派生类用来实现自己的对象
        //个人理解为，分离从原始抽象类抽象出来的对象和从原始抽象类精炼出一个抽象类中抽象出来的对象。
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();
    
            abstraction.SetImplementor(new ConcreteImplementorB());
            abstraction.Operation();
    
            Console.Read();
        }
    }
}