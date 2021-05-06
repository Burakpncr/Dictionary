using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(1, "Burak");
            sehirler.Add(1, "Burak");
            sehirler.Add(1, "Burak");
            Console.WriteLine(sehirler.Count);
            
        }
    }
}
