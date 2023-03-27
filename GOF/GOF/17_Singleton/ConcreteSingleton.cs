namespace GOF._17_Singleton
{
    /// <summary>
    /// 具体的某个想要实现单例的类
    /// </summary>
    public class ConcreteSingleton : Singleton<ConcreteSingleton>
    {
        public string Data;
    }
}
