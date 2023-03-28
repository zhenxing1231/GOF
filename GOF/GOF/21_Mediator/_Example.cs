namespace GOF._21_Mediator
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //中介者模式用一个中介对象来封装不同的对象交互，使交互的双方不需要相互引用，从而实现解耦。一般运用于一组对象以定义良好但复杂的方式进行通信的场合。
        //个人理解为像是为一个功能做的一个管理类，虽然对象之间解耦合了，但是该管理类的复杂程度会上升很多。
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 c2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;
    
            c1.Send("lalalalalalala");
            c2.Send("hahahahahahaha");
            Console.Read();
        }
    }
}