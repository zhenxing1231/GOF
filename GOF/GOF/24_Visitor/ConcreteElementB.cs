namespace GOF._24_Visitor
{
    /// <summary>
    /// 具体元素类B
    /// </summary>
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitorConcreteElementB(this);
        }
    }
}