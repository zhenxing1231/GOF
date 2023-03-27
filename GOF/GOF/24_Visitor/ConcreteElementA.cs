namespace GOF._24_Visitor
{
    /// <summary>
    /// 具体元素类A
    /// </summary>
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcreteElementA(this);
        }
    }
}
