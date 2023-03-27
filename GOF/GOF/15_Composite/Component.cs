namespace GOF._15_Composite
{
    /// <summary>
    /// 抽象组件类
    /// </summary>
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int Depth);
    }
}
