namespace GOF._15_Composite
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        
        //组合模式 个人感觉就是在构建一颗树， 用来表示整体的结构，同时每一个节点都能共有同一个相似的操作。感觉是一个比较少用的模式
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Composite root = new Composite("Root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite composite1 = new Composite("composite1");
            composite1.Add(new Leaf("Leaf C"));
            composite1.Add(new Leaf("Leaf D"));
    
            root.Add(composite1);
    
            root.Display(1);
    
            Console.Read();
        }
    }
}