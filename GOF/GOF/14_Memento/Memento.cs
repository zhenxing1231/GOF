namespace GOF._14_Memento
{
    /// <summary>
    /// 备忘录类
    /// </summary>
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string State
        {
            get
            {
                return _state;
            }
        }
    }
}
