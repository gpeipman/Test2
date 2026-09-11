using HelloWorldLib;

namespace HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hello = HelloWorld.GetHello();
            Console.WriteLine(hello);
        }
    }
}
