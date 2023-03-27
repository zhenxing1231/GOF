namespace GOF._24_Visitor
{
    /// <summary>
    /// 元素构造类，提供一个接口允许访问者访问元素
    /// </summary>
    public class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }
        
        public void Attach(params Element[] element)
        {
            foreach (var VARIABLE in element)
            {
                _elements.Add(VARIABLE);
            }
        }

        public void Detach(Element element)
        {
            if (_elements.Contains(element))
            {
                _elements.Remove(element);
            }
        }

        public void Accept(Visitor visitor)
        {
            foreach (var VARIABLE in _elements)
            {
                VARIABLE.Accept(visitor);
            }
        }
    }
}
