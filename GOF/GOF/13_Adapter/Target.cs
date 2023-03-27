namespace GOF._13_Adapter
{
    /// <summary>
    /// 目标接口
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}
