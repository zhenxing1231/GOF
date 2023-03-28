namespace GOF._22_Flyweight
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //享元模式是运用共享技术有效地支持大量细粒度的对象，可以避免大量非常相似类的开销
        //个人理解这种模式类似于对象池技术。
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            int extrinsicstate = 30;

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight f1 = factory.GetFlyweight("1");
            f1.Operation(--extrinsicstate);
    
            Flyweight f2 = factory.GetFlyweight("2");
            f2.Operation(--extrinsicstate);
    
            Flyweight f3 = factory.GetFlyweight("3");
            f3.Operation(--extrinsicstate);
    
            Flyweight f4 = factory.GetFlyweight("3");
            f4.Operation(--extrinsicstate);

            Flyweight flyweight = new UnsharedConcreteFlyweight();
            flyweight.Operation(--extrinsicstate);

            Console.WriteLine($"工厂示例总数：{factory.GetInstanceCount()}");
    
            Console.Read();
        }
    }
}