namespace GOF._17_Singleton
{
    /// <summary>
    /// 实现单例的类，继承该类即可实现单例模式
    /// </summary>
    public class Singleton<T> where T: new()
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}
