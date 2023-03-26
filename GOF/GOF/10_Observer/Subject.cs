namespace GOF._10_Observer
{
    /// <summary>
    /// 抽象通知类
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> Observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var VARIABLE in Observers)
            {
                VARIABLE.Update();
            }
        }
    }
}
