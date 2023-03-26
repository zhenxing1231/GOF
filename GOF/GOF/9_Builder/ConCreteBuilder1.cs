namespace GOF._9_Builder
{
    
    public class ConCreteBuilder1 : Builder
    {
        private Product _product = new Product();
        public override void BuilderPartA()
        {
            _product.Add("Part1");
        }

        public override void BuilderPartB()
        {
            _product.Add("Part2");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
