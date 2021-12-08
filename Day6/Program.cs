using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("input.txt");

            List<int> list = buildList(lines[0]);
            fishEvolution(list,80);

        }

        



        static void fishEvolution(List<int> list, int days){
            for(int d = 0; d < days; d++){
                int numberOfLoops = list.Count;
                for(int fish = 0; fish < numberOfLoops; fish++){
                    if(list[fish] == 0){
                        list[fish] = 7;
                        list.Add(8);
                    }
                    list[fish] -= 1;
                }
            }
            Console.WriteLine(list.Count);
        }


        private static List<int> buildList(string s){
            List<int> newList = new List<int>();

            for(int i = 0; i < s.Length; i++){
                if(s[i] != ','){
                    newList.Add(s[i] - '0');
                }
            }
            return newList;
        }



    }
}
