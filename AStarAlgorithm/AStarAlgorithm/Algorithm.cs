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
            List<Node> closedNodes = new List<Node>();

            openNodes.Add(start);

            while (openNodes.Count > 0)
            {
                Node current = openNodes[0];

                openNodes.Remove(current);
                closedNodes.Add(current);
            }

            return path;
        }
    }
}