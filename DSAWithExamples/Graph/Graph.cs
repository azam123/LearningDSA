using System;
using System.Collections.Generic;
/// <summary>
/// Explanation:
//Graph Class: Implements a basic graph using an adjacency list, where each vertex has a list of its neighbors.
//AddVertex Method: Adds a new vertex to the graph.
//AddEdge Method: Adds an edge between two vertices.
//This example assumes an undirected graph; for a directed graph, you would only add the edge from vertex1 to vertex2.
//GetNeighbors Method: Returns the list of neighbors for a given vertex.
//DisplayGraph Method: Displays the adjacency list of the graph.Explanation:
//Graph Class: Implements a basic graph using an adjacency list, where each vertex has a list of its neighbors.
//AddVertex Method: Adds a new vertex to the graph.
//AddEdge Method: Adds an edge between two vertices. This example assumes an undirected graph;
//for a directed graph, you would only add the edge from vertex1 to vertex2.
//GetNeighbors Method: Returns the list of neighbors for a given vertex.
//DisplayGraph Method: Displays the adjacency list of the graph.
/// </summary>
public class Graph
{
    private Dictionary<int, List<int>> _adjacencyList;

    public Graph()
    {
        _adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddVertex(int vertex)
    {
        if (!_adjacencyList.ContainsKey(vertex))
        {
            _adjacencyList[vertex] = new List<int>();
        }
    }

    public void AddEdge(int vertex1, int vertex2)
    {
        if (_adjacencyList.ContainsKey(vertex1) && _adjacencyList.ContainsKey(vertex2))
        {
            _adjacencyList[vertex1].Add(vertex2);
            _adjacencyList[vertex2].Add(vertex1); // For an undirected graph
        }
    }

    public List<int> GetNeighbors(int vertex)
    {
        if (_adjacencyList.ContainsKey(vertex))
        {
            return _adjacencyList[vertex];
        }

        return new List<int>();
    }

    public void DisplayGraph()
    {
        foreach (var vertex in _adjacencyList)
        {
            Console.Write(vertex.Key + ": ");
            foreach (var neighbor in vertex.Value)
            {
                Console.Write(neighbor + " ");
            }
            Console.WriteLine();
        }
    }
}
