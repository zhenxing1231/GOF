namespace GOF._12_State
{
    /// <summary>
    /// 具体状态A
    /// </summary>
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}