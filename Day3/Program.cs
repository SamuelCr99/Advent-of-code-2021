using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines("input.txt");
            int[] countArray = {0,0,0,0,0,0,0,0,0,0,0,0};
            for (int i = 0; i < input.Length; i++){
                String currentLine = input[i];
                for (int k = 0; k < 12; k++){
                    if(currentLine[k] == '1'){
                        countArray[k] += 1;
                    }
                    else{
                        countArray[k] -= 1;
                    }
                }
            }
            int[] newArrayGamma = getCorrectGamma(countArray);
            int[] newArrayEpsilon = getCorrectEpsilon(countArray);

            int gamma = binaryToDecimal(newArrayGamma);
            int epsilon = binaryToDecimal(newArrayEpsilon);

            Console.WriteLine(gamma*epsilon);

        }

        private static int[] getCorrectGamma(int [] arr){
            int[] newArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++){
                if(arr[i] > 0){
                    newArray[i] = 1;
                }
                else{
                    newArray[i] = 0;
                }
            }
            return newArray;
        }


        private static int[] getCorrectEpsilon(int [] arr){
            int[] newArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    newArray[i] = 1;
                }
                else{
                    newArray[i] = 0;
                }
            }
            return newArray;
        }
        

        private static int binaryToDecimal (int[] arr){
            int val = 0; 
            
            for (int i = arr.Length-1; i >= 0; i--){
                val += arr[i] * (int)(Math.Pow(2,arr.Length-1-i));
            }
            return val;
        }

    }
}
