namespace GOF._23_Interpreter
{
    /// <summary>
    /// 抽象表达式类
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
