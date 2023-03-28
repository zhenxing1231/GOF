namespace GOF._2_Strategy
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //策略模式定义了一个算法家族，使各个算法之间可以相互替换使用，算法的变化并不会影响其他的功能
        //这是一种非常实用的模式
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Context context = new Context(new StrategyA());
            context.ContextInterface();
    
            context = new Context(new StrategyB());
            context.ContextInterface();
            Console.Read();
        }
    }
}