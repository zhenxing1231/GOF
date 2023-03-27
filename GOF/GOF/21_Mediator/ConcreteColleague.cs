namespace GOF._21_Mediator
{
    /// <summary>
    /// 具体同事类1
    /// </summary>
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator){}

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="message"></param>
        public void Send(string message)
        {
            _mediator.Send(message,this);
        }
        
        /// <summary>
        /// 通知消息
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            Console.WriteLine($"同事1收到消息：{message}");
        }
    }
}
