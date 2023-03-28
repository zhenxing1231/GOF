namespace GOF._6_Prototype
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //个人感觉原型模式真正需要想到使用的地方可能比较少，但是如果需要有克隆一个类的需求可以将该类继承ICloneable接口，底层官方已经帮你实现了
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ConcreatePrototypeA A = new ConcreatePrototypeA("这是A的数据");
            ConcreatePrototypeA B = (ConcreatePrototypeA) A.Clone();
    
            Console.WriteLine($"B从A克隆过来的数据为： {B.Value}");
            Console.Read();
        }
    }
}