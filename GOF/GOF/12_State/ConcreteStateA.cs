namespace GOF._12_State
{
    /// <summary>
    /// 具体状态A
    /// </summary>
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
