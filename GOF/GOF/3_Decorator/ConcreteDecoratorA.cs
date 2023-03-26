namespace GOF._3_Decorator
{
    /// <summary>
    /// 具体的装饰类A
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        public override void Opreation()
        {
            base.Opreation();
            Console.WriteLine("具体装饰类A做了一套实现");
        }
    }
}
