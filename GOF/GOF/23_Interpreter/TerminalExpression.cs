namespace GOF._23_Interpreter
{
    /// <summary>
    /// 终结符表达式
    /// </summary>
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终止");
        }
    }
}
