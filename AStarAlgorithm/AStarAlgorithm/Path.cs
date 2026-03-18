using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Path
    {
        private List<Node> nodes;

        public Path(List<Node> nodes)
        {
            this.nodes = nodes;
        }

        public List<Node> Nodes
        {
            get { return nodes; }
        }
    }
}