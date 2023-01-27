using System;
using UnityEngine;

public class Graph : MonoBehaviour {
    public int[,] graph = {
        {0,4,0,0,0,11,8,5,6},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
        {0,11,0,3,0,1,1,0,5},
    };

    private void Start() {
        Dijkstra.DijkstraAlgorythm(graph, 0,9);
    }
}
