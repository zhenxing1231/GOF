namespace GOF._22_Flyweight
{
    /// <summary>
    /// 不共享的具体享元类
    /// </summary>
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"不共享的具体Flyweight ：{extrinsicstate}");
        }
    }
}
