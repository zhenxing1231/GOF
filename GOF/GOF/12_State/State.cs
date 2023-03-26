namespace GOF._12_State
{
    /// <summary>
    /// 抽象状态类
    /// </summary>
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
