namespace GOF._24_Visitor
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //访问者模式 表示一个作用于某对象结构中的各元素的操作，可以在不改变元素类的前提下定义作用于这些元素的新操作
        //访问者模式适用于数据结构相对稳定的系统，即在Visitor类中虚方法是比较固定的，比如这里就只有A、B两个类别，如果这个类别不固定，那么就比较麻烦。

        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ObjectStructure objectStructure = new ObjectStructure();
    
            objectStructure.Attach(new ConcreteElementA(),new ConcreteElementB());

            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();
    
            objectStructure.Accept(visitor1);
            objectStructure.Accept(visitor2);
    
            Console.Read();
        }
    }
}