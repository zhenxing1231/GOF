namespace GOF._18_Bridge
{
    /// <summary>
    /// 具体实现类A
    /// </summary>
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现A的方法");
        }
    }
}
