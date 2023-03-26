namespace GOF._10_Observer
{
    /// <summary>
    /// 具体观察者类
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteSubject Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }
        
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            _name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"观察者{_name}的当前状态为{_observerState}");
        }

        
    }
}
