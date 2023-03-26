namespace GOF._12_State
{
    /// <summary>
    /// 状态实例类
    /// </summary>
    public class Context
    {
        private State _state;

        public State State
        {
            set
            {
                _state = value;
                Console.WriteLine($"当前状态为：{_state.GetType().Name}");
            }
        }

        public Context(State state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
