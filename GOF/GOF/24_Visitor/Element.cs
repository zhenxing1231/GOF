namespace GOF._24_Visitor
{
    /// <summary>
    /// 抽象元素类
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
