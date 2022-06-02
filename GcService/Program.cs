// See https://aka.ms/new-console-template for more information

using GcService.Model;

Console.WriteLine("max generation :{0}" ,GC.MaxGeneration);
Console.WriteLine("total memory:{0}", GC.GetTotalMemory(false));

//person
Person person = new Person();
Console.WriteLine("person generation:{0}", GC.GetGeneration(person));

//
//person = null;
//GC.Collect();
//
GC.SuppressFinalize(person);
GC.WaitForPendingFinalizers();


//dispose
using(person = new Person())
{

}
Console.WriteLine("Hello, World!");
Console.ReadKey();
