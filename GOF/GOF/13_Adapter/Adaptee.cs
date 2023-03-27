namespace GOF._13_Adapter
{
    /// <summary>
    /// 需要适配的类
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }
}
