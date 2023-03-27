namespace GOF._19_Command
{
    /// <summary>
    /// 具体命令类
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) {}

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}
