namespace GOF._19_Command
{
    /// <summary>
    /// 调用者
    /// </summary>
    public class Invoker
    {
        private List<Command> _listCommands = new List<Command>();

        public void SetCommand(params Command[] commands)
        {
            foreach (var VARIABLE in commands)
            {
                _listCommands.Add(VARIABLE);
            }
        }

        /// <summary>
        /// 调运者执行命令
        /// </summary>
        public void ExecuteCommand()
        {
            foreach (var VARIABLE in _listCommands)
            {
                VARIABLE.Execute();
            }
        }
    }
}
