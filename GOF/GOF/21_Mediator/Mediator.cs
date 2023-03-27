namespace GOF._21_Mediator
{
    /// <summary>
    /// 抽象中介类
    /// </summary>
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);

    }
}
