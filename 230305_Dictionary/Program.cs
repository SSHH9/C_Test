using System;
using System.Collections.Generic;

//일반화 컬렉션
namespace _230305_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DictionaryAA = new Dictionary<string, int>();

            DictionaryAA.Add("10", 10);
            DictionaryAA.Add("20", 20);
            DictionaryAA["30"] = 30;

            foreach (var key in DictionaryAA.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, DictionaryAA[key]);
            }
            Console.WriteLine();

            Dictionary<int, string> DictionaryInit = new Dictionary<int, string>()
            {
                [1] = "Hello",
                [100] = "Dictionary",
                [1000] = "Good",
            };

            foreach (var key in DictionaryInit.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, DictionaryInit[key]);
            }

            string getvalue = string.Empty;
            DictionaryInit.TryGetValue(1, out getvalue);
            Console.WriteLine("\nTry get value: {0}", getvalue);

            DictionaryInit.TryGetValue(11, out getvalue);
            Console.WriteLine("\nTry get value: {0}", getvalue);
        }
    }
}
