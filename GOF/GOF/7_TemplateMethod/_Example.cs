namespace GOF._7_TemplateMethod
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //模板方法模式可以将相同的行为搬移到超类中，这样就可以减少其在子类中的重复出现，这是一个非常常用的模式
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            AbstractClass abs;
            abs = new ConcreteClassA();
            abs.TemplateMethod();
            Console.WriteLine("-----------------------");
            abs = new ConcreteClassB();
            abs.TemplateMethod();
            Console.Read();
        }
    }
}