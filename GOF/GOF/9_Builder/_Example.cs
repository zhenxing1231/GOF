namespace GOF._9_Builder
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //建造者模式使构建和显示分离，当创建复杂对象的算法应该独立于该对象的组成部分以及他们的装配方式时使用该模式
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            Director director = new Director();
            Builder b1 = new ConCreteBuilder1();
            Builder b2 = new ConCreteBuilder2();
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();
            Console.WriteLine("-------------------------");
            director.Construct(b2);
            Console.Read();
        }
    }
}