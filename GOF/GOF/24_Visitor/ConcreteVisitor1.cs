﻿namespace GOF._24_Visitor
{
    /// <summary>
    /// 具体访问者类1
    /// </summary>
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitorConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}被{this.GetType().Name}访问了");
        }

        public override void VisitorConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name}被{this.GetType().Name}访问了");
        }
    }
}
