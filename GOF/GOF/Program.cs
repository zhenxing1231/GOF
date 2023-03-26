// See https://aka.ms/new-console-template for more information


#region 简单工厂 (轻知识)

//简单工厂是一个在同一个工厂中通过Switch分支生产出不同的运算类，这违背了开放-封闭原则，当新增运算类时就需要改动工厂类中的分支。
//所以在这里只写了加法的实现，如果想要实际运用，建议使用第5个工厂方法模式。

// using _1_SimpleFactory;
//
// static void Main()
// {
//     Operation operation = OperationFactory.CreateOperation(OperationType.Add);
//     operation.Arg1 = 10;
//     operation.Arg2 = 23;
//     Console.WriteLine($"运算结果：{operation.GetResult()}");
// }

#endregion

#region 策略模式 （重点）

// using GOF._2_Strategy;
//
// static void Main()
// {
//     Context context = new Context(new StrategyA());
//     context.ContextInterface();
//     
//     context = new Context(new StrategyB());
//     context.ContextInterface();
// }

#endregion

#region 装饰模式 （重点）

// using GOF._3_Decorator;
//
// static void Main()
// {
//     ConcreteComponent component = new ConcreteComponent();
//     ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
//     ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();
//     FinalDecorator finalDecorator = new FinalDecorator();
//     
//     decoratorA.SetComponent(component);
//     decoratorB.SetComponent(decoratorA);
//     finalDecorator.SetComponent(decoratorB);
//     
//     finalDecorator.Opreation();
// }

#endregion

#region 代理模式 (轻知识)

// using GOF._4_Proxy;
//
// //个人感觉代理模式真正需要想到使用的地方可能比较少，更像是用于对实体的隐藏
//
// static void Main()
// {
//     Proxy proxy = new Proxy();
//     proxy.Request();
// }

#endregion

#region 工厂方法模式 （重点）

// using GOF._5_FactoryMethod;
//
// //工厂方法模式与简单工厂不同，它将工厂的创建变成了一个接口，然后由不同的工厂类实现这个接口，相当于把方法的实现延后至不同的工厂类中。
// //这样的做法就完全符合开放-封闭原则，如果需要添加新的运算，只需要添加新的运算类与生产该运算类的工厂类即可。
//
// static void Main()
// {
//     IFactory Operatory = new FactoryAdd();
//     Operation operation = Operatory.CreateOperation();
//     operation.Arg1 = 22;
//     operation.Arg2 = 90;
//     
//     Console.WriteLine($"运算结果：{operation.GetResult()}");
// }

#endregion

#region 原型模式 (轻知识)

// using GOF._6_Prototype;
//
// //个人感觉原型模式真正需要想到使用的地方可能比较少，但是如果需要有克隆一个类的需求可以将该类继承ICloneable接口，底层官方已经帮你实现了
//
// static void Main()
// {
//     ConcreatePrototypeA A = new ConcreatePrototypeA("这是A的数据");
//     ConcreatePrototypeA B = (ConcreatePrototypeA) A.Clone();
//     
//     Console.WriteLine($"B从A克隆过来的数据为： {B.Value}");
// }

#endregion

#region 模板方法模式 （常用）

// using GOF._7_TemplateMethod;
//
// //模板方法模式可以将相同的行为搬移到超类中，这样就可以减少其在子类中的重复出现，这是一个非常常用的模式
//
// static void Main()
// {
//     AbstractClass abs;
//     abs = new ConcreteClassA();
//     abs.TemplateMethod();
//     Console.WriteLine("-----------------------");
//     abs = new ConcreteClassB();
//     abs.TemplateMethod();
// }


#endregion

#region 外观模式 （常用）

// using GOF._8_Facade;
//
// //外观模式定义了一个高层接口用来管理和调用子系统，这是一个非常常用的模式
//
// static void Main()
// {
//     Facade facade = new Facade();
//     facade.FunctionA();
//     Console.WriteLine("-----------------------");
//     facade.FunctionB();
// }

#endregion

#region 建造者模式 （重点）

// using GOF._9_Builder;
//
// //建造者模式使构建和显示分离，当创建复杂对象的算法应该独立于该对象的组成部分以及他们的装配方式时使用该模式
//
// static void Main()
// {
//     Director director = new Director();
//     Builder b1 = new ConCreteBuilder1();
//     Builder b2 = new ConCreteBuilder2();
//     director.Construct(b1);
//     Product p1 = b1.GetResult();
//     p1.Show();
//     Console.WriteLine("-------------------------");
//     director.Construct(b2);
//     
// }


#endregion

#region 观察者模式 （重点）

// using GOF._10_Observer;
//
// //观察者模式 当一个对象改变是需要同时改变其他对象，并且他不知道具体有多少对象有待改变时，应该考虑使用观察者模式
//
// static void Main()
// {
//     ConcreteSubject subject = new ConcreteSubject();
//     subject.Attach(new ConcreteObserver(subject,"XXX"));
//     subject.Attach(new ConcreteObserver(subject,"OOO"));
//     subject.Attach(new ConcreteObserver(subject,"PPP"));
//     subject.SubjectState = "TaTaKai";
//     subject.Notify();
//     Console.WriteLine("-------------------------");
//     subject.SubjectState = "OK";
//     subject.Notify();
// }


#endregion

#region 抽象工厂模式 （重点）

// using GOF._11_AbstractFactory;
// //抽象工厂模式 提供一个创建一系列相关或者相互依赖对象的接口，而无需指定它们具体的类
//
// // static void Main()
// // {
// //     AbstractFactory factory = new ConcreteFactory1();
// //     //AbstractFactory factory = new ConcreteFactory2();
// //     
// //     AbstractProductA productA = factory.CreateProductA();
// //     AbstractProductB productB = factory.CreateProductB();
// //
// //     productA.GetFactoryID();
// //     productB.GetFactoryName();
// // }
//
// //进阶技巧，使用反射加抽象工厂来实现通过字符串来控制程序的运行，这里可以将该字符串进行文件读取操作得到，然后实现改配置切换不同的工厂
// using System.Reflection;
//
// static void AdvanceMain()
// {
//     AbstractFactory factory =
//         (AbstractFactory) Assembly.Load("GOF").CreateInstance("GOF._11_AbstractFactory.ConcreteFactory2");
//     
//     AbstractProductA productA = factory.CreateProductA();
//     AbstractProductB productB = factory.CreateProductB();
//
//     productA.GetFactoryID();
//     productB.GetFactoryName();
// }
//
// AdvanceMain();

#endregion

#region 状态模式 （重点）

// using GOF._12_State;
//
// //状态模式 用于把状态判断的逻辑转移到表示不同状态的一系列类中，把复杂的判断逻辑简化。
// //实际的运行更像是动画机里面的一个个节点转移。
//
// static void Main()
// {
//     Context context = new Context(new ConcreteStateA());
//     context.Request();
//     context.Request();
//     context.Request();
//     context.Request();
// }

#endregion

#region 适配器模式 

using GOF._13_Adapter;

static void Main()
{
    
}

#endregion


Main();