using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            int smaller = Int32.Parse(lines[0]);
            for (int i = 3; i < lines.Length; i++){
                int first = Int32.Parse(lines[i-3]);
                int second = Int32.Parse(lines[i-2]);
                int third = Int32.Parse(lines[i-1]);
                int fourth = Int32.Parse(lines[i]);

                if(fourth > first) {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
