namespace GOF._9_Builder
{
    
    public class ConCreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuilderPartA()
        {
            _product.Add("Part4");
        }

        public override void BuilderPartB()
        {
            _product.Add("Part5");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}