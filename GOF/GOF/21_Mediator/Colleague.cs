namespace GOF._21_Mediator
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}
