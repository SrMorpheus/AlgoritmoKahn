using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kahn
{
    public class Graph
    {
        public List<List<int>> ListAdjacencias { get; set; }

        public List<int> Grau { get; set; }

       public Graph(List<Edge> edges, int n)
       {
            ListAdjacencias = new List<List<int>>();

            Grau = new List<int>();

            for (int i = 0; i < n; i++)
            {

                ListAdjacencias.Add(new List<int>());

                Grau.Add(0);

            }

            foreach (var edge in edges)
            {

                ListAdjacencias[edge.Src].Add(edge.Dest);

                 Grau[edge.Dest]++;

            }

       }

    }
}
