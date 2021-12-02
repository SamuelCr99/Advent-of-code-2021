using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int pos = 0;
            int aim = 0; 

            string[] lines = System.IO.File.ReadAllLines("input.txt");
            for (int i = 0; i < lines.Length; i++){
                String line = lines[i];
                if(line.Contains("forward")){
                    int val = Convert.ToInt32(Char.GetNumericValue(line[8]));
                    pos += val;
                    depth += val*aim;

                }
                else if(line.Contains("up")){
                    int val = Convert.ToInt32(Char.GetNumericValue(line[3]));
                    aim -= val;

                }
                else if(line.Contains("down")){
                    int val = Convert.ToInt32(Char.GetNumericValue(line[5]));
                    aim   += val;
                }
            }
            Console.WriteLine(depth*pos);
        }
    }
}
