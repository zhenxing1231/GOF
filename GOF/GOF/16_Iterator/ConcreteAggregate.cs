namespace GOF._16_Iterator
{
    /// <summary>
    /// 具体的聚集类
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private List<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items.Insert(index,value);
            }
        }
    }
}
