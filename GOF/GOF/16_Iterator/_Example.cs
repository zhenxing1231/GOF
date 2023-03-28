namespace GOF._16_Iterator
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //迭代器模式 C#官方的foreach就是迭代器模式的一个实现案例
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();

            for (int i = 0; i < 9; i++)
            {
                aggregate[i] = (i+1).ToString();
            }

            Iterator iterator = new ConcreteIterator(aggregate);

            object item = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine($"{iterator.CurrentItem()}");
                iterator.Next();
            }
    
            Console.Read();
        }
    }
}