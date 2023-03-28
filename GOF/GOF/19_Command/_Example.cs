namespace GOF._19_Command
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //命令模式用于将一个请求封装为一个对象，从而实现对不同请求进行参数化，还能进行排队或记录请求日志，以及未调用前支持撤销操作。
        //该模式可以轻松实现一个命令队列，并且进行日志记录
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            //创建接收者
            Receiver receiver = new Receiver();
            //创建命令并指定接收者
            Command command1 = new ConcreteCommand(receiver);
            Command command2 = new ConcreteCommand(receiver);
            //创建调用者
            Invoker invoker = new Invoker();
            invoker.SetCommand(command1,command2);
            invoker.ExecuteCommand();
    
            Console.Read();
        }
    }
}