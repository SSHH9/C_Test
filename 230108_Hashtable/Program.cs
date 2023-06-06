using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            
            // key + value 함께 넣어줘야 함
            hashtable.Add("pos", 10);
            hashtable.Add("name", "Jack");
            hashtable["weight"] = 10.8f;

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashtable[key]);
            }

            Console.WriteLine("");

            Hashtable hashTableCopy = new Hashtable()
            {
                ["pos"] = 10,
                ["name"] = "Jack",
                ["weight"] = 10.8f,
            };

            foreach (object key in hashTableCopy.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTableCopy[key]);
            }
        }
    }
}
