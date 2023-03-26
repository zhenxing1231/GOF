namespace GOF._7_TemplateMethod
{
    /// <summary>
    /// 实体子类A
    /// </summary>
    public class ConcreteClassA : AbstractClass
    {
        public override void Funtion1()
        {
            Console.WriteLine("实体类A实现的方法1");
        }
        
        public override void Funtion2()
        {
            Console.WriteLine("实体类A实现的方法2");
        }
    }
}
