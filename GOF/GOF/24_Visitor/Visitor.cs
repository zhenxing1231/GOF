namespace GOF._24_Visitor
{
    /// <summary>
    /// 抽象访问者类
    /// </summary>
    public abstract class Visitor
    {
        public abstract void VisitorConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitorConcreteElementB(ConcreteElementB concreteElementB);
    }
}
