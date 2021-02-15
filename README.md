# HauntedHouseGame

The document contains important scripts used in the project and the exported asset of game. The game has main focus on A* path tracing algorithm mostly used in games in AI. To open the game in Unity, import the unity package inside HauntedHouse Document.

A* algorithm is the Informed Search Algorithm used to find the shortest path with cost function. Cost function is implemented using the heuristic value and actual cost value.

Consider, the cost function is F'(N) given as-

    F'(N) = G(N) + H'(N)
         
    where, 
    F'(N) = Cost Function (Approximate value). It is the cost value to reach from initial state to final state.
    G(N)  = It is the actual value to reach from initial state to current state.
    H'(N) = It is the approximate heuristic value to reach from current state to final state.
 

In this project, Euclidean Distance is used as an heuristic function. The two lists namely **OPEN** and **CLOSED** are implemented internally in this project. The OPEN list contains the states which are generated but not processed. While CLOSED list contains the states which are generated and proocessed(created further successors of this current state).

To know more about A* algorithm, check out thee links given below:

   - [**Introduction to the A\* Algorithm**](https://www.redblobgames.com/pathfinding/a-star/introduction.html)
   - [**A\* Algorithm for Path Finding in Games**](https://www.coderewind.com/2012/08/a-algorithm-for-path-finding-in-games/)
   - [**A\* Search Algorithm**](https://www.geeksforgeeks.org/a-search-algorithm/)

