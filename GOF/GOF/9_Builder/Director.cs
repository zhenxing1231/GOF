namespace GOF._9_Builder
{
    /// <summary>
    /// 指挥者类，指挥建造过程
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }
}
