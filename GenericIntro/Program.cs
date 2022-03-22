using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Recep");
            Console.WriteLine("Hello World!");
        }
    }
}
