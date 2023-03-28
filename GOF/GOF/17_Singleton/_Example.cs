namespace GOF._17_Singleton
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //单例模式是一个非常常用的模式，作用是保持唯一的实例，并提供一个全局访问的入口
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ConcreteSingleton c1 = ConcreteSingleton.Instance;
            c1.Data = "C1";

            ConcreteSingleton c2 = ConcreteSingleton.Instance;
            c2.Data = "C2";
    
            Console.WriteLine($"{c1.Data} || {c2.Data}");
    
            Console.Read();
        }
    }
}