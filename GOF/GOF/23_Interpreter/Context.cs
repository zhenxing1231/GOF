namespace GOF._23_Interpreter
{
    /// <summary>
    /// 内容类
    /// </summary>
    public class Context
    {
        private int _input;
        public int Input
        {
            set
            {
                _input = value;
            }
            get
            {
                return _input;
            }
        }

        public Context(int input)
        {
            _input = input;
        }
        
        //以下是书籍中的案例，但是我觉得不如自己写的这一个表示的透彻，所以注释掉并且自己小改动了一部分
        
        // private string _input;
        // public string Input
        // {
        //     set
        //     {
        //         _input = value;
        //     }
        //     get
        //     {
        //         return _input;
        //     }
        // }

        // private string _output;
        // public string Output
        // {
        //     set
        //     {
        //         _output = value;
        //     }
        //     get
        //     {
        //         return _output;
        //     }
        // }
        
        
    }
}
