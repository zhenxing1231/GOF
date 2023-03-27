namespace GOF._23_Interpreter
{
    /// <summary>
    /// 非终结符表达式
    /// </summary>
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            switch (context.Input)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("B");
                    break;
                case 3:
                    Console.WriteLine("C");
                    break;
                case 4:
                    Console.WriteLine("D");
                    break;
                default:
                    break;
            }
        }
    }
}
