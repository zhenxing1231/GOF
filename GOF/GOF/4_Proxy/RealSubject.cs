namespace GOF._4_Proxy
{
    /// <summary>
    /// 真实的主题类
    /// </summary>
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真正的请求");
        }
    }
}
