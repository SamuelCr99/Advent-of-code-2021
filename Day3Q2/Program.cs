using System;

namespace Day3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines("input.txt");
            for (int i = 0; i < input[0].Length; i++){
                int numberOfOne = 0;
                for (int k = 0; k < input.Length; k++){
                    if (input[k] == null){
                        continue;
                    }
                    String line = input[k];
                    if (line[i] == '1'){
                        numberOfOne += 1;
                    }
                    else{
                        numberOfOne -= 1;
                    }
                }
                char key = '0';
                if(numberOfOne > 0){
                    key = '1';
                }
                for (int k = 0; k < input.Length; k++){
                    String line = input[k];
                    if (line[i] != key){
                        input[k] = null;
                    }
                 
                }
            }

    }
    }
}
