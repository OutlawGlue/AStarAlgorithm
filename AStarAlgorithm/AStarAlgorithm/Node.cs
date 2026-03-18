using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Node
    {
        private readonly int row;
        private readonly int col;
        private char value;
        private bool canAccess; //indicates if the node is walkable (not a wall)
        private Node parent; //reference to the parent node for path reconstruction

        private int gCost = 0; //current cost from start to this node
        private int hCost = int.MaxValue; //estimated cost from this node to target (heuristic)
        private int fCost => gCost + fCost; //total cost (gCost + hCost)

        public Node(int row, int col, char value)
        {
            this.row = row;
            this.col = col;
            this.value = value;
        }

        public int Row
        {
            get { return row; }
        }

        public int Col
        {
            get { return col; }
        }

        public bool CanAccess
        {
            get { return canAccess; }
        }

        public int GCost
        {
            get { return gCost; }
        }

        public int HCost
        {
            get { return hCost; }
        }

        public int FCost
        {
            get { return fCost; }
        }

        public char GetValue()
        {
            return value;
        }
    }
}