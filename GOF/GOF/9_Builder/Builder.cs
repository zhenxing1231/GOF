namespace GOF._9_Builder
{
    /// <summary>
    /// 建造抽象类
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Product GetResult();
    }
}
