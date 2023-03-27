namespace GOF._21_Mediator
{
    /// <summary>
    /// 具体中介者类
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public ConcreteColleague1 Colleague1
        {
            set
            {
                _colleague1 = value;
            }
        }
        
        public ConcreteColleague2 Colleague2
        {
            set
            {
                _colleague2 = value;
            }
        }

        public override void Send(string message, Colleague colleague)
        {
            Console.WriteLine($"{colleague.GetType().Name}发送出一条消息：{message}");
            //这里其实可以用上一个责任链模式来优化
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else if (colleague == _colleague2)
            {
                _colleague1.Notify(message);
            }
        }
    }
}