namespace GOF._20_ChainOfResponsibility
{
    /// <summary>
    /// 具体处理请求类1
    /// </summary>
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            //这里做判断决定是否该类处理还是移交给下一级处理
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name}处理请求{request}");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
            
        }
    }
}
