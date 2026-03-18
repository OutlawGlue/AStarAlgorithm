using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Get basic inputs:
            Console.Write("Enter grid size (rows, cols): ");
            int[] gridSize = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write("Enter starting location (row, col):");
            int[] start = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write("Enter target location (row, col):");
            int[] target = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            //Create required objects:
            Grid grid = new Grid(gridSize[0], gridSize[1]);
            Node startNode = grid.GetCell(start[0], start[1]);
            Node targetNode = grid.GetCell(target[0], target[1]);

            Algorithm algorithm = new Algorithm(grid);
            Path path = algorithm.FindPath(startNode, targetNode);

            foreach (Node node in path.Nodes)
            {
                Console.WriteLine($"({node.Row}, {node.Col})");
            }
        }
    }
}