namespace Delegate_C_Sharp
{
    public delegate void Func(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter String:");
            var str=Console.ReadLine();
            MyClass myClass = new MyClass();
            Func func = myClass.Reverse;
            func += myClass.Space;

            Run run = new Run();
            run.RunFunc(func,str);


        }
    }
}