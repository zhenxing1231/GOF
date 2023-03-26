namespace GOF._6_Prototype
{
    /// <summary>
    /// 具体的原型对象
    /// </summary>
    public class ConcreatePrototypeA : Prototype 
    {
        public ConcreatePrototypeA(string value) : base(value)
        {
            
        }
        
        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }
}
