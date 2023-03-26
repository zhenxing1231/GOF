namespace GOF._10_Observer
{
    /// <summary>
    /// 具体通知类
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private string _SubjectState;

        public string SubjectState
        {
            set
            {
                _SubjectState = value;
            }
            get
            {
                return _SubjectState;
            }
        }
    }
}
