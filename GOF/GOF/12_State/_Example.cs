namespace GOF._12_State
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //状态模式 用于把状态判断的逻辑转移到表示不同状态的一系列类中，把复杂的判断逻辑简化。
        //实际的运行更像是动画机里面的一个个节点转移。
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.Read();
        }
    }
}