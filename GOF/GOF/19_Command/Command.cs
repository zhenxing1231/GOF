namespace GOF._19_Command
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }
        
        /// <summary>
        /// 抽象执行方法
        /// </summary>
        public abstract void Execute();
    }
}
