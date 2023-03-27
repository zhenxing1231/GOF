namespace GOF._15_Composite
{
    /// <summary>
    /// 分支节点
    /// </summary>
    public class Composite : Component
    {
        public Composite(string name) : base(name){ }
        
        /// <summary>
        /// 该节点的所有子节点
        /// </summary>
        private List<Component> children = new List<Component>();

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-',Depth) + _name);

            foreach (var VARIABLE in children)
            {
                VARIABLE.Display(Depth + 1);
            }
        }
    }
}
