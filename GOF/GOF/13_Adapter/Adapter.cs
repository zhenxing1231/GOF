namespace GOF._13_Adapter
{
    /// <summary>
    /// 适配器类，用于将目标接口转化成适配接口
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
