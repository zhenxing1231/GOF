namespace GOF._8_Facade
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //外观模式定义了一个高层接口用来管理和调用子系统，这是一个非常常用的模式
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Facade facade = new Facade();
            facade.FunctionA();
            Console.WriteLine("-----------------------");
            facade.FunctionB();
            Console.Read();
        }
    }
}