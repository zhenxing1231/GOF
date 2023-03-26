namespace GOF._8_Facade
{
    /// <summary>
    /// 外观类，这是一个对多系统的总管理
    /// </summary>
    public class Facade
    {
        private SubSystemA A;
        private SubSystemB B;

        public Facade()
        {
            A = new SubSystemA();
            B = new SubSystemB();
        }

        public void FunctionA()
        {
            Console.WriteLine($"执行方法A，先调用A系统，再调用B系统");
            A.FunctionA();
            B.FunctionB();
        }
        
        public void FunctionB()
        {
            Console.WriteLine($"执行方法B，先调用B系统，再调用A系统");
            B.FunctionB();
            A.FunctionA();
        }
    }
}
