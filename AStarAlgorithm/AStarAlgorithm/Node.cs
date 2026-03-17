using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Node
    {
        private int row;
        private int col;
        private char value;

        public Node(int row, int col, char value)
        {
            this.row = row;
            this.col = col;
            this.value = value;
        }

        public char GetValue()
        {
            return value;
        }
    }
}