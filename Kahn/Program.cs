using Kahn;


    //exemplo

    List<Edge> edges = new List<Edge> {
        new Edge(0, 6), new Edge(1, 2), new Edge(1, 4),
        new Edge(1, 6), new Edge(3, 0), new Edge(3, 4),
        new Edge(5, 1), new Edge(7, 0), new Edge(7, 1)
    };
    int n = 8;

    Graph graph = new Graph(edges, n);

    var listOrdenacao = CoreKahn.TopologicalSort(graph, n);

    if (listOrdenacao != null)
    {

        foreach( var ordens in listOrdenacao)
         {

            Console.Write(ordens + " ");

        }
    }

    else
    {
        Console.WriteLine("grafo tem pelo menos um ciclo " +
        "A classificação topológica não é possível");
    }