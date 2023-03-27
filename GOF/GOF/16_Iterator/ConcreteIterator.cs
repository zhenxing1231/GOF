namespace GOF._16_Iterator
{
    /// <summary>
    /// 具体的迭代器类
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int current = 0;
        
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < _aggregate.Count)
            {
                ret = _aggregate[current];
            }

            return ret;
        }

        public override bool IsDone()
        {
            return current >= _aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return _aggregate[current];
        }
    }
}
