using System.Collections;

namespace GOF._22_Flyweight
{
    /// <summary>
    /// 享元工厂，用于创建并管理Flyweight对象
    /// </summary>
    public class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        // public FlyweightFactory()
        // {
        //     _flyweights.Add("1",new ConcreteFlyweight());
        //     _flyweights.Add("2",new ConcreteFlyweight());
        //     _flyweights.Add("3",new ConcreteFlyweight());
        // }
        
        
        public Flyweight GetFlyweight(string key)
        {
            if (_flyweights.ContainsKey(key))
            {
                return (Flyweight)_flyweights[key];
            }
            else
            {
                ConcreteFlyweight newFlyweight = new ConcreteFlyweight();
                _flyweights.Add(key,newFlyweight);
                return newFlyweight;
            }
        }

        public int GetInstanceCount()
        {
            return _flyweights.Count;
        }
    }
}
