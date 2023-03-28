namespace GOF._10_Observer
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //观察者模式 当一个对象改变是需要同时改变其他对象，并且他不知道具体有多少对象有待改变时，应该考虑使用观察者模式
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject,"XXX"));
            subject.Attach(new ConcreteObserver(subject,"OOO"));
            subject.Attach(new ConcreteObserver(subject,"PPP"));
            subject.SubjectState = "TaTaKai";
            subject.Notify();
            Console.WriteLine("-------------------------");
            subject.SubjectState = "OK";
            subject.Notify();
            Console.Read();
        }
    }
}