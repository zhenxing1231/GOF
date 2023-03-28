namespace GOF._1_SimpleFactory
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        
        //简单工厂是一个在同一个工厂中通过Switch分支生产出不同的运算类，这违背了开放-封闭原则，当新增运算类时就需要改动工厂类中的分支。
        //所以在这里只写了加法的实现，如果想要实际运用，建议使用第5个工厂方法模式。
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Operation operation = OperationFactory.CreateOperation(OperationType.Add);
            operation.Arg1 = 10;
            operation.Arg2 = 23;
            Console.WriteLine($"运算结果：{operation.GetResult()}");
            Console.Read();
        }
    }
}
