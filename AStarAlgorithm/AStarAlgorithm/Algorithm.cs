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
        private Node start;
        private Node target;

        public Algorithm(Grid grid, Node start, Node target)
        {
            this.grid = grid;
            this.start = start;
            this.target = target;
        }

        public Path Run()
        {
            Path path = new Path();
            return path;
        }
    }
}