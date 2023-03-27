namespace GOF._15_Composite
{
    /// <summary>
    /// 叶节点
    /// </summary>
    public class Leaf : Component
    {
        public Leaf(string name) : base(name){ }

        public override void Add(Component component)
        {
            Console.WriteLine("Error:不能添加子节点");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Error:不能移除子节点");
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-',Depth) + _name);
        }
    }
}
