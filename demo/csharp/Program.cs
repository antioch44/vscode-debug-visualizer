#nullable enable

using System;
using Hediet.DebugVisualizer.ExtractedData;

namespace Demo
{
    class Node<T>
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var g = new GraphData();
            g.Nodes.Add(new NodeGraphData("1"));
            g.Nodes.Add(new NodeGraphData("2"));
            g.Edges.Add(new EdgeGraphData("1", "2"));

            Console.WriteLine(g.ToString());
        }
    }
}
