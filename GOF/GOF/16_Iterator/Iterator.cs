namespace GOF._16_Iterator
{
    /// <summary>
    /// 抽象迭代器类
    /// </summary>
    public abstract class Iterator
    {
        /// <summary>
        /// 获取第一个对象
        /// </summary>
        /// <returns></returns>
        public abstract object First();
        /// <summary>
        /// 获得下一个对象
        /// </summary>
        /// <returns></returns>
        public abstract object Next();
        /// <summary>
        /// 是否已经是最后一个对象
        /// </summary>
        /// <returns></returns>
        public abstract bool IsDone();
        /// <summary>
        /// 获取当前对象
        /// </summary>
        /// <returns></returns>
        public abstract object CurrentItem();
    }
}
