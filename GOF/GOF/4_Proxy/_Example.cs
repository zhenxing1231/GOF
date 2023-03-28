namespace GOF._4_Proxy
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        
        //个人感觉代理模式真正需要想到使用的地方可能比较少，更像是用于对实体的隐藏
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.Read();
        }
    }
}