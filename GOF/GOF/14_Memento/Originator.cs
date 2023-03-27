namespace GOF._14_Memento
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class Originator
    {
        private string _state;

        public string State
        {
            set
            {
                _state = value;
            }
            get
            {
                return _state;
            }
        }
        
        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }
        
        /// <summary>
        /// 还原数据
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            _state = memento.State;
        }
        
        /// <summary>
        /// 查询当前状态
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"当前的状态：{_state}");
        }
    }
}
