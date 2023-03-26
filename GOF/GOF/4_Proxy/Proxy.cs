namespace GOF._4_Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            if (_realSubject == null)//如果代理对象为空那么就创建一个代理对象
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
