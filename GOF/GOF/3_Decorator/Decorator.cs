namespace GOF._3_Decorator
{
    /// <summary>
    /// 装饰类
    /// </summary>
    public class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Opreation()
        {
            if (_component != null)
            {
                _component.Opreation();
            }
        }
    }
}
