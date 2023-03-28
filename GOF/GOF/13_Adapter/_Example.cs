namespace GOF._13_Adapter
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //适配器模式主要是用于对于已经存在的类，它的接口相似但是不完全相同，并且不太容易修改的时候使用，更像是一种补救措施
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Target target = new Adapter();
            target.Request();
            Console.Read();
        }
    }
}