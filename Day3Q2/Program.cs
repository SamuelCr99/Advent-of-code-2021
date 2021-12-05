using System;

namespace Day3Q2
{
    class Program
    {
        static void Main(string[] args)
        {//So this code is really ugly but I spent 2 hours bug fixing it so now it will have to look like this! 
            string[] input = System.IO.File.ReadAllLines("input.txt");

            int oxygenGeneration = calcValue(input,'1','0');
            input = System.IO.File.ReadAllLines("input.txt"); //Resets the array. 
            int cO2Generation = calcValue(input,'0','1');

            Console.WriteLine(oxygenGeneration*cO2Generation); 
            
        }

        private static int binaryToDecimal (string s){
            int val = 0; 
            for (int i = s.Length-1; i >= 0; i--){
                int Currentval = s[i] - '0';
                val += Currentval * (int)(Math.Pow(2,s.Length-1-i));
            }
            return val;
        }

        private static string findNonNull (string [] array){
            for (int i = 0; i < array.Length; i++){
                if (array[i] != "null"){
                    return array[i];
                }
            }
            throw new InvalidOperationException("File should always find one value, other code is wrong");
        }

        private static void showArray (string[] array){
            for(int i = 0; i < array.Length; i++){
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("---------------------");
        }

        private static int amountNonNull (string [] array){
            int counter = 0;
            for (int i = 0; i < array.Length; i++){
                if (array[i] != "null"){
                    counter++;
                }
            }
            return counter;
        }

        private static int calcValue (string [] input, char standard, char possible){            
            int rowLen = input[0].Length;

            for(int i = 0; i < rowLen; i++){
                if (amountNonNull(input) == 1){
                    break;
                }

                int counter = 0;
                for(int k = 0; k < input.Length; k++){
                    string word = input[k];

                    if(word == "null"){
                        continue;
                    }

                    if (word[i] == '1'){
                        counter++;
                    }
                    if(word[i] == '0'){
                        counter--;
                    }
                }
                char lookFor = standard;
                if (counter < 0){
                    lookFor = possible;
                }
                for (int k = 0; k < input.Length; k++){
                    string word = input[k];
                    if(word == "null"){
                        continue;
                    }
                    if (word[i] != lookFor){
                        input[k] = "null";
                    }
                }
            }
            return binaryToDecimal(findNonNull(input));              
        }



        


    }
}
