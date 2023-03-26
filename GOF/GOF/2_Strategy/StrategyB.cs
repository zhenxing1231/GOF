namespace GOF._2_Strategy
{
    /// <summary>
    /// 策略B
    /// </summary>
    public class StrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现策略B的算法...");
        }
    }
}