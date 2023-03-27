namespace GOF._20_ChainOfResponsibility
{
    /// <summary>
    /// 具体处理请求类2
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            //这里做判断决定是否该类处理还是移交给下一级处理
            if (request >= 10 && request < 20)
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