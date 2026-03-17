using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Grid
    {
        private char[,] grid;

        public Grid(int width, int height)
        {
            grid = new char[width, height];
        }

        public char GetCell(int row, int col)
        {
            return grid[row, col];
        }
    }
}