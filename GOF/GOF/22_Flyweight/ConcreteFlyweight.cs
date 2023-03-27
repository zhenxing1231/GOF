namespace GOF._22_Flyweight
{
    /// <summary>
    /// 具体享元类
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"具体Flyweight为：{extrinsicstate}");
        }
    }
}
