using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Grid
    {
        private Node[,] grid;
        private readonly int rows;
        private readonly int cols;

        public Grid(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            SetUpGrid();
        }

        private void SetUpGrid()
        {
            //Don't need to worry about rows -1 here
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Node temp = new Node(row, col, '.');
                    grid[row, col] = temp;
                }
            }
        }

        public Node GetCell(int row, int col)
        {
            return grid[row, col];
        }

        public List<Node> GetNeighbours(Node current)
        {
            int row = current.Row;
            int col = current.Col;

            //Validate:
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                return null;
            }

            List<Node> neighbours = new List<Node>();

            //Top:
            if (row > 0)
            {
                neighbours.Add(grid[row - 1, col]);
            }
            //Bottom:
            if (row < rows - 1)
            {
                neighbours.Add(grid[row + 1, col]);
            }
            //Left:
            if (col > 0)
            {
                neighbours.Add(grid[row, col - 1]);
            }
            //Right:
            if (col < cols - 1)
            {
                neighbours.Add(grid[row, col + 1]);
            }

            return neighbours;
        }
    }
}