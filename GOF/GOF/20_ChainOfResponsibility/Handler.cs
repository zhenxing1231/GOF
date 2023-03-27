namespace GOF._20_ChainOfResponsibility
{
    /// <summary>
    /// 抽象处理请求的接口
    /// </summary>
    public abstract class Handler
    {
        protected Handler _successor;

        /// <summary>
        /// 设置继任者
        /// </summary>
        /// <param name="successor"></param>
        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }
        /// <summary>
        /// 抽象处理请求方法
        /// </summary>
        /// <param name="request"></param>
        public abstract void HandleRequest(int request);
    }
}
