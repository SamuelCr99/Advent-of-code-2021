using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = System.IO.File.ReadAllLines("input.txt");                
            int [] array = buildArray(input[0]);
            Console.WriteLine(array[1]);
        }

        private static int[] buildArray(string s){
            int[] intArr = new int [s.Length];
            int keepCount = 0;
            for(int i = 0; i < s.Length; i++){
                if (s[i] != ','){
                   intArr[keepCount] = s[i] - '0';
                   keepCount++; 
                }
            }
            return intArr;
        }
    }
}
