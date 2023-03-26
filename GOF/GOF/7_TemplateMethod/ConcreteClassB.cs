namespace GOF._7_TemplateMethod
{
    /// <summary>
    /// 实体子类B
    /// </summary>
    public class ConcreteClassB : AbstractClass
    {
        public override void Funtion1()
        {
            Console.WriteLine("实体类B实现的方法1");
        }
        
        public override void Funtion2()
        {
            Console.WriteLine("实体类B实现的方法2");
        }
    }
}
