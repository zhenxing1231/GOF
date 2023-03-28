namespace GOF._14_Memento
{
    /// <summary>
    /// 实例
    /// </summary>
    public class _Example : AbstractExample
    {
        //备忘录模式，用来存储细节，以备某个时刻用于恢复存储当时的状态 
        
        /// <summary>
        /// 运行方法
        /// </summary>
        public override void Run()
        {
            Main();
        }

        private void Main()
        {
            //初始化状态
            Originator originator = new Originator();
            originator.State = "开启";
            originator.Show();
            //管理者记录当前的状态
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            //状态改变
            originator.State = "关闭";
            originator.Show();
    
            //还原状态
            originator.SetMemento(caretaker.Memento);
            originator.Show();
    
            Console.Read();
        }
    }
}