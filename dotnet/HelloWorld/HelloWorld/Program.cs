using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Person myobj = new Person();
            myobj.Name = "Kanishk";
            Console.WriteLine(myobj.Name);
        }
    }
}