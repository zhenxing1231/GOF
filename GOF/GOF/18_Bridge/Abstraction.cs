namespace GOF._18_Bridge
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public class Abstraction
    {
        protected Implementor _implementor;

        public void SetImplementor(Implementor implementor)
        {
            _implementor = implementor;
        }
        
        public virtual void Operation()
        {
            _implementor.Operation();
        }
    }
}
