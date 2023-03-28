namespace GOF._23_Interpreter
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //解释器模式 给定一个语言，定义它的文法的一种表示，并定义一个解释器用来解释语言中的句子。
        //个人感觉需要自己实现并使用的地方较少，本质上类似于构造一套的正则表达式一样的东西
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            List<int> temp = new List<int>() {1, 3, 2, 4, 2, 2, 3, 4, 1, 2, 1};
    
            AbstractExpression expression = new NonterminalExpression();
            for (int i = 0; i < temp.Count; i++)
            {
                Context context = new Context(temp[i]);
                expression.Interpret(context);
                if (i == temp.Count - 1)
                {
                    expression = new TerminalExpression();
                    expression.Interpret(context);
                }
            }
    
            Console.Read();
        }
    }
}