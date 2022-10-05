using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahn
{
    public class CoreKahn
    {
        public static List<int>  TopologicalSort( Graph graph , int n)
        {

            var listOrdenados = new List<int>();

            var indegree = graph.Grau;

            var S = new Stack<int>();
            
            for (int i = 0; i < n; i++)
            {

                if (indegree[i] == 0 ) S.Push(i);

            }

            while (S.Count != 0)
            {

                int i = S.Pop();

                listOrdenados.Add(i);

                foreach ( var m in graph.ListAdjacencias[i])
                {

                    indegree[m]--;

                    if (indegree[m] == 0) S.Push(m);


                }


            }

            for (int i = 0 ; i < n ; i++)
            {

                if (indegree[i] != 0 )
                {

                    return null;
                }

            }

            return listOrdenados;
        }
    }
}
