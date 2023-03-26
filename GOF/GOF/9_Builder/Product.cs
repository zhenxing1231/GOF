namespace GOF._9_Builder
{
    /// <summary>
    /// 产品类
    /// </summary>
    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("--------------");
            foreach (var VARIABLE in parts)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
