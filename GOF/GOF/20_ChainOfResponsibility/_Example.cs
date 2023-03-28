namespace GOF._20_ChainOfResponsibility
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //职责链模式可以按照一条链去传递处理一个请求，直到该请求被处理
        //个人理解，该模式非常适合用于if-else的结构的解耦合，但是需要注意构建一条合理且完备的链，否则将会出现逻辑问题
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
    
            h1.SetSuccessor(h2);
    
            h1.HandleRequest(4);
            h1.HandleRequest(18);
    
            Console.Read();
        }
    }
}