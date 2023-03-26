namespace GOF._2_Strategy
{
    /// <summary>
    /// 策略A
    /// </summary>
    public class StrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现策略A的算法...");
        }
    }
}

