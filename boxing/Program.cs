using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> lis = new List<object>();
            lis.Add(7);
            lis.Add(28);
            lis.Add(-1);
            lis.Add(true);
            lis.Add("chair");
            int sum = 0;
            foreach (object obj in lis){
                Console.WriteLine(obj);
                if(obj is int){
                    sum += (int) obj;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
