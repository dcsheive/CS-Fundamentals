using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4,5,6,7,8,9};
            string[] arr2 = {"Tim", "Martin", "Nikki", "Sara", "Michael"};
            bool[] arr3 = {true,false,true,false,true,false,true,false,true,false};
            List<string> flavors = new List<string>();
            flavors.Add("apple");
            flavors.Add("banana");
            flavors.Add("orange");
            flavors.Add("blueberry");
            flavors.Add("grape");
            Dictionary<string,string> dict = new Dictionary<string,string>(); 
            dict.Add(arr2[0],flavors[0]);
            dict.Add(arr2[1],flavors[1]);
            dict.Add(arr2[2],flavors[2]);
            dict.Add(arr2[3],flavors[3]);
            dict.Add(arr2[4],flavors[4]);
            foreach(var entry in dict){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            };
        }
    }
}
