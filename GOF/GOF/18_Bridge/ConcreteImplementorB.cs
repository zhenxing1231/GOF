namespace GOF._18_Bridge
{
    /// <summary>
    /// 具体实现类B
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法");
        }
    }
}