namespace GOF._3_Decorator
{
    /// <summary>
    /// 具体的组件类
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Opreation()
        {
            Console.WriteLine("具体对象创建成功");
        }
    }
}
