namespace GOF._3_Decorator
{
    /// <summary>
    /// 具体的装饰类B
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public override void Opreation()
        {
            base.Opreation();
            Console.WriteLine("具体装饰类B做了一套实现");
        }
    }
}