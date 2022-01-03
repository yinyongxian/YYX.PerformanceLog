// See https://aka.ms/new-console-template for more information

using System.Reflection;
using log4net;
using log4net.Config;
using YYX.PerformanceLog;

var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

//using Loger loger = new();
//Foo();

using (Loger loger = new())
{
    Foo();
}

Console.WriteLine("YYX");

void Foo() => Thread.Sleep(2000);