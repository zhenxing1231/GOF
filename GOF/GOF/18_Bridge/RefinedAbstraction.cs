namespace GOF._18_Bridge
{
    /// <summary>
    /// 精炼抽象类
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _implementor.Operation();
        }
    }
}
