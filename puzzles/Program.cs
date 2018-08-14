using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(CoinToss());
            Console.WriteLine(MultiToss(5));
        }
        public static int[] RandomArray(){
            int[] arr = new int[10];
            Random r = new Random();
            int sum = 0;
            int max = 0;
            int min = 0;
            for (int i = 0; i<10; i++){
                arr[i] = r.Next(5,26);
                if (i==0){
                    max = arr[0];
                    min = arr[0];
                }
                sum += arr[i];
                if (arr[i]>max){
                    max = arr[i];
                }
                if (arr[i]<min){
                    min = arr[i];
                }
            }
            Console.WriteLine($"Max: {max}, Min: {min}, Sum: {sum}");
            return arr;
        }
        public static string CoinToss(){
            Random r = new Random();
            int result = r.Next(0,2);
            if (result == 1){
                return "Heads";
            }
            return "Tails";
        }
        public static double MultiToss(int num){
            double heads = 0;
            double tails = 0;
            for(int i = 0; i<num; i++){
                if(CoinToss()=="Heads"){
                    heads++;
                }
                else {
                    tails++;
                }
            }
            double res = heads/tails;
            return res;
        }
    }
}
