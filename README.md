# AStarAlgorithm
C# A star path-finding algorithm

## Project Inspiration

While browsing online games I came across **Barricade.gg**, a simple but interesting strategy game based on moving a player across a grid while placing barriers to block opponents. The idea immediately stood out because the game appears simple on the surface, but it relies heavily on underlying pathfinding logic to determine whether players can still reach their goal.

Seeing this made me curious about how the movement and path validation might work behind the scenes. In games like Barricade, every time a barrier is placed the game must ensure that a valid route to the goal still exists. This requires an efficient algorithm capable of finding the shortest path across a grid while accounting for obstacles.

To begin exploring this problem, I decided to implement the **A\*** (A-star) pathfinding algorithm. A\* is widely used in games because it efficiently finds the shortest path between two points while prioritising movement towards the goal. Compared to simpler approaches, it avoids searching unnecessary areas of the grid, making it well suited for real-time gameplay.

Starting with an implementation of A\* allows this project to build a reusable pathfinding system that can:

- Calculate the shortest route across a grid
- Adapt to dynamic obstacles such as walls or barriers
- Be reused in other grid-based games or simulations

This repository therefore begins with the development of a **general-purpose A\*** pathfinding implementation in C#. Once the algorithm is working reliably, it can be integrated into a larger system that recreates the core mechanics of Barricade-style gameplay.
