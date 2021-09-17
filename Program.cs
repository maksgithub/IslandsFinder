using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[,]
            {
                { 2, 2, 2, 2, 2, 2, 2, 2, 2 },
                { 2, 0, 0, 0, 0, 1, 0, 1, 2 },
                { 2, 0, 1, 1, 0, 0, 1, 1, 2 },
                { 2, 0, 0, 1, 0, 0, 0, 1, 2 },
                { 2, 0, 0, 0, 1, 0, 0, 1, 2 },
                { 2, 0, 1, 0, 0, 0, 1, 0, 2 },
                { 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            };
            var finder = new IslandsFinder();
            var res = finder.FindMaxIslandSize(matrix);
        }
    }
}
