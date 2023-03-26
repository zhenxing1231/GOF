namespace GOF._6_Prototype
{
    /// <summary>
    /// 原型抽象类
    /// </summary>
    public abstract class Prototype
    {
        private string _value;

        public Prototype(string value)
        {
            _value = value;
        }

        public string Value
        {
            get
            {
                return _value;
            }
        }

        public abstract Prototype Clone();
    }
}
