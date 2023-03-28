namespace GOF._5_FactoryMethod
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //工厂方法模式与简单工厂不同，它将工厂的创建变成了一个接口，然后由不同的工厂类实现这个接口，相当于把方法的实现延后至不同的工厂类中。
        //这样的做法就完全符合开放-封闭原则，如果需要添加新的运算，只需要添加新的运算类与生产该运算类的工厂类即可。
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            IFactory Operatory = new FactoryAdd();
            Operation operation = Operatory.CreateOperation();
            operation.Arg1 = 22;
            operation.Arg2 = 90;
    
            Console.WriteLine($"运算结果：{operation.GetResult()}");
            Console.Read();
        }
    }
}