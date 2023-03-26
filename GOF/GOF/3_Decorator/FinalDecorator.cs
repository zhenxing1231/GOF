namespace GOF._3_Decorator
{
    /// <summary>
    /// 最终封装的装饰类，所有装饰完成的实体最后都要被这个类装饰，实现统一管理
    /// </summary>
    public class FinalDecorator : Decorator
    {
        public override void Opreation()
        {
            base.Opreation();
        }
    }
}
