using System;

namespace ConsoleApp1
{
    public class IslandsFinder
    {
        private readonly int[] _x = new int[] { -1, -1, 0, 1, 1, 1, 0, -1 };
        private readonly int[] _y = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };

        public uint FindMaxIslandSize(int[,] matrix)
        {
            uint res = 0;
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] != 2)
                    {
                        uint s = 0;
                        Dfs(matrix, i, j, ref s);
                        res = Math.Max(s, res);
                    }
                }
            }

            return res;
        }

        private void Dfs(int[,] matrix, int x, int y, ref uint size)
        {
            matrix[x, y] = 2;
            for (int i = 0; i < _x.Length; i++)
            {
                var newX = x + _x[i];
                var newY = y + _y[i];

                if (matrix[newX, newY] == 1)
                {
                    size += 1;
                    Dfs(matrix, newX, newY, ref size);
                }
            }
        }
    }
}