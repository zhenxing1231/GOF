namespace GOF._7_TemplateMethod
{
    /// <summary>
    /// 抽象父类，定义模板方法和一些抽象行为，给子类去实现
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void Funtion1();
        public abstract void Funtion2();

        public void TemplateMethod()
        {
            Funtion1();
            Funtion2();
        }
    }
}
