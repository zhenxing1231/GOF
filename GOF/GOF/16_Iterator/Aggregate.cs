namespace GOF._16_Iterator
{
    /// <summary>
    /// 抽象聚集类
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// 创建迭代器
        /// </summary>
        /// <returns></returns>
        public abstract Iterator CreateIterator();
    }
}
