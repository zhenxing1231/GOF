namespace GOF._2_Strategy
{
    /// <summary>
    /// 环境类
    /// </summary>
    public class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
