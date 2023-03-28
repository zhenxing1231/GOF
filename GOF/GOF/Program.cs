using GOF;
using System.Reflection;


//选择案例运行模式
Mode mode = Mode._24_Visitor;

AbstractExample example = (AbstractExample)Assembly.Load("GOF").CreateInstance($"GOF.{mode}._Example");

example.Run();

