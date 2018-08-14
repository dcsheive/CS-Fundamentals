using System;

namespace basic13
{
    class Program
    {
        public static void print255(){
            for(int i = 1; i<256;i++){
                Console.WriteLine(i);
            }
        }
        public static void printOdd255(){
            for(int i = 1; i<256;i+=2){
                Console.WriteLine(i);
            }
        }
        public static void printSum255(){
            int sum = 0;
            for(int i = 0; i<256;i++){
                sum+=i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }
        public static void printArray(int[] arr){
            for(int i = 0; i<arr.Length;i++){
                Console.WriteLine(arr[i]);
            }
        }
        public static void printArrayMax(int[] arr){
            int max = arr[0];
            for(int i = 0; i<arr.Length;i++){
                if (arr[i] > max){
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        public static void printArrayAvg(int[] arr){
            double max = 0;
            for(int i = 0; i<arr.Length;i++){
                max += arr[i];
            }
            Console.WriteLine(max/arr.Length);
        }
        public static void printGreaterThan(int[] arr, int y ){
            int count = 0;
            for(int i = 0; i<arr.Length;i++){
                if (arr[i]>y){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void squareArray(int[] arr ){
            for(int i = 0; i<arr.Length;i++){
                arr[i] *= arr[i];
            }
            for(int i = 0; i<arr.Length;i++){
                Console.WriteLine(arr[i]);
            }
            
        }
        public static void printMinMaxAvg(int[] arr){
            double sum = 0;
            double min = arr[0];
            double max = arr[0];
            for(int i = 0; i<arr.Length;i++){
                sum += arr[i];
                if(arr[i]>max){
                    max = arr[i];
                }
                if(arr[i]<min){
                    min = arr[i];
                }
            }
            sum /= arr.Length;
            Console.WriteLine($"Min: {min}, Max: {max}, Avg: {sum}");
        }
        public static void shiftLeft(int[] arr){
            for(int i = 0; i<arr.Length-1;i++){
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = 0;
            
            for(int i = 0; i<arr.Length;i++){
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            // print255();
            // printOdd255();
            // printSum255();
            int[] arr = {1,3,5,7,9,13};
            // printArray(arr);
            // printArrayMax(arr);
            // printArrayAvg(arr);
            // printGreaterThan(arr, 6);
            // squareArray(arr);
            // printMinMaxAvg(arr);
            // shiftLeft(arr);
        }
    }
}
