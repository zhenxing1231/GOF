namespace GOF._14_Memento
{
    /// <summary>
    /// 管理者类
    /// </summary>
    public class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set
            {
                _memento = value;
            }
            get
            {
                return _memento;
            }
        }
    }
}
