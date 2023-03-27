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

#region 适配器模式 (常用)

// using GOF._13_Adapter;
//
// //适配器模式主要是用于对于已经存在的类，它的接口相似但是不完全相同，并且不太容易修改的时候使用，更像是一种补救措施
//
// static void Main()
// {
//     Target target = new Adapter();
//     target.Request();
//     Console.Read();
// }

#endregion

#region 备忘录模式 （重点）

// using GOF._14_Memento;
//
// //备忘录模式，用来存储细节，以备某个时刻用于恢复存储当时的状态 
//
// static void Main()
// {
//     //初始化状态
//     Originator originator = new Originator();
//     originator.State = "开启";
//     originator.Show();
//     //管理者记录当前的状态
//     Caretaker caretaker = new Caretaker();
//     caretaker.Memento = originator.CreateMemento();
//     //状态改变
//     originator.State = "关闭";
//     originator.Show();
//     
//     //还原状态
//     originator.SetMemento(caretaker.Memento);
//     originator.Show();
//     
//     Console.Read();
// }

#endregion

#region 组合模式 （轻知识）

// using GOF._15_Composite;
//
// //组合模式 个人感觉就是在构建一颗树， 用来表示整体的结构，同时每一个节点都能共有同一个相似的操作。感觉是一个比较少用的模式
//
// static void Main()
// {
//     Composite root = new Composite("Root");
//     root.Add(new Leaf("Leaf A"));
//     root.Add(new Leaf("Leaf B"));
//
//     Composite composite1 = new Composite("composite1");
//     composite1.Add(new Leaf("Leaf C"));
//     composite1.Add(new Leaf("Leaf D"));
//     
//     root.Add(composite1);
//     
//     root.Display(1);
//     
//     Console.Read();
// }


#endregion

#region 迭代器模式 （轻知识）

// using GOF._16_Iterator;
//
// //迭代器模式 C#官方的foreach就是迭代器模式的一个实现案例
//
// static void Main()
// {
//     ConcreteAggregate aggregate = new ConcreteAggregate();
//
//     for (int i = 0; i < 9; i++)
//     {
//         aggregate[i] = (i+1).ToString();
//     }
//
//     Iterator iterator = new ConcreteIterator(aggregate);
//
//     object item = iterator.First();
//     while (!iterator.IsDone())
//     {
//         Console.WriteLine($"{iterator.CurrentItem()}");
//         iterator.Next();
//     }
//     
//     Console.Read();
// }

#endregion

#region 单例模式 （重点）

// using GOF._17_Singleton;
//
// //单例模式是一个非常常用的模式，作用是保持唯一的实例，并提供一个全局访问的入口
//
// static void Main()
// {
//     ConcreteSingleton c1 = ConcreteSingleton.Instance;
//     c1.Data = "C1";
//
//     ConcreteSingleton c2 = ConcreteSingleton.Instance;
//     c2.Data = "C2";
//     
//     Console.WriteLine($"{c1.Data} || {c2.Data}");
//     
//     Console.Read();
// }

#endregion

#region 桥接模式 （重点）

// using GOF._18_Bridge;
//
// //桥接模式可以将抽象部分和实现部分分离，这个实现是指抽象类和它的派生类用来实现自己的对象
// //个人理解为，分离从原始抽象类抽象出来的对象和从原始抽象类精炼出一个抽象类中抽象出来的对象。
//
// static void Main()
// {
//     Abstraction abstraction = new RefinedAbstraction();
//     abstraction.SetImplementor(new ConcreteImplementorA());
//     abstraction.Operation();
//     
//     abstraction.SetImplementor(new ConcreteImplementorB());
//     abstraction.Operation();
//     
//     Console.Read();
// }


#endregion

#region 命令模式 (重点)

// using GOF._19_Command;
//
// //命令模式用于将一个请求封装为一个对象，从而实现对不同请求进行参数化，还能进行排队或记录请求日志，以及未调用前支持撤销操作。
// //该模式可以轻松实现一个命令队列，并且进行日志记录
//
// static void Main()
// {
//     //创建接收者
//     Receiver receiver = new Receiver();
//     //创建命令并指定接收者
//     Command command1 = new ConcreteCommand(receiver);
//     Command command2 = new ConcreteCommand(receiver);
//     //创建调用者
//     Invoker invoker = new Invoker();
//     invoker.SetCommand(command1,command2);
//     invoker.ExecuteCommand();
//     
//     Console.Read();
// }

#endregion

#region 职责链模式 （重点）

// using GOF._20_ChainOfResponsibility;
//
// //职责链模式可以按照一条链去传递处理一个请求，直到该请求被处理
// //个人理解，该模式非常适合用于if-else的结构的解耦合，但是需要注意构建一条合理且完备的链，否则将会出现逻辑问题
//
// static void Main()
// {
//     Handler h1 = new ConcreteHandler1();
//     Handler h2 = new ConcreteHandler2();
//     
//     h1.SetSuccessor(h2);
//     
//     h1.HandleRequest(4);
//     h1.HandleRequest(18);
//     
//     Console.Read();
// }

#endregion

#region 中介者模式 （重点）


// using GOF._21_Mediator;
//
// //中介者模式用一个中介对象来封装不同的对象交互，使交互的双方不需要相互引用，从而实现解耦。一般运用于一组对象以定义良好但复杂的方式进行通信的场合。
// //个人理解为像是为一个功能做的一个管理类，虽然对象之间解耦合了，但是该管理类的复杂程度会上升很多。
//
// static void Main()
// {
//     ConcreteMediator mediator = new ConcreteMediator();
//
//     ConcreteColleague1 c1 = new ConcreteColleague1(mediator);
//     ConcreteColleague2 c2 = new ConcreteColleague2(mediator);
//
//     mediator.Colleague1 = c1;
//     mediator.Colleague2 = c2;
//     
//     c1.Send("lalalalalalala");
//     c2.Send("hahahahahahaha");
//     Console.Read();
// }


#endregion

#region 享元模式 （常用）

// using GOF._22_Flyweight;
//
// //享元模式是运用共享技术有效地支持大量细粒度的对象，可以避免大量非常相似类的开销
// //个人理解这种模式类似于对象池技术。
//
// static void Main()
// {
//     int extrinsicstate = 30;
//
//     FlyweightFactory factory = new FlyweightFactory();
//
//     Flyweight f1 = factory.GetFlyweight("1");
//     f1.Operation(--extrinsicstate);
//     
//     Flyweight f2 = factory.GetFlyweight("2");
//     f2.Operation(--extrinsicstate);
//     
//     Flyweight f3 = factory.GetFlyweight("3");
//     f3.Operation(--extrinsicstate);
//     
//     Flyweight f4 = factory.GetFlyweight("3");
//     f4.Operation(--extrinsicstate);
//
//     Flyweight flyweight = new UnsharedConcreteFlyweight();
//     flyweight.Operation(--extrinsicstate);
//
//     Console.WriteLine($"工厂示例总数：{factory.GetInstanceCount()}");
//     
//     Console.Read();
// }

#endregion

#region 解释器模式 （轻知识）

// using GOF._23_Interpreter;
//
// //解释器模式 给定一个语言，定义它的文法的一种表示，并定义一个解释器用来解释语言中的句子。
// //个人感觉需要自己实现并使用的地方较少，本质上类似于构造一套的正则表达式一样的东西
//
// static void Main()
// {
//     List<int> temp = new List<int>() {1, 3, 2, 4, 2, 2, 3, 4, 1, 2, 1};
//     
//     AbstractExpression expression = new NonterminalExpression();
//     for (int i = 0; i < temp.Count; i++)
//     {
//         Context context = new Context(temp[i]);
//         expression.Interpret(context);
//         if (i == temp.Count - 1)
//         {
//             expression = new TerminalExpression();
//             expression.Interpret(context);
//         }
//     }
//     
//     Console.Read();
// }


#endregion

#region 访问者模式 （重点）

using GOF._24_Visitor;

//访问者模式 表示一个作用于某对象结构中的各元素的操作，可以在不改变元素类的前提下定义作用于这些元素的新操作
//访问者模式适用于数据结构相对稳定的系统，即在Visitor类中虚方法是比较固定的，比如这里就只有A、B两个类别，如果这个类别不固定，那么就比较麻烦。

static void Main()
{
    ObjectStructure objectStructure = new ObjectStructure();
    
    objectStructure.Attach(new ConcreteElementA(),new ConcreteElementB());

    ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
    ConcreteVisitor2 visitor2 = new ConcreteVisitor2();
    
    objectStructure.Accept(visitor1);
    objectStructure.Accept(visitor2);
    
    Console.Read();
}


#endregion


























Main();