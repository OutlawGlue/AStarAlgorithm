using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Algorithm
    {
        private Grid grid;

        public Algorithm(Grid grid)
        {
            this.grid = grid;
        }

        public Path FindPath(Node start, Node end)
        {
            Path path = new Path();
            List<Node> openNodes = new List<Node>();
            List<Node> closeNodes = new List<Node>();

            return path;
        }
    }
}