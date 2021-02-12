using MyDictionaryProject;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customers = new MyDictionary<int, string>();
            customers.Add(10, "Murat");
            customers.Add(94, "Talisca");
            customers.Add(33, "Gomez");
            customers.ToList();
            
        }
    }
}
