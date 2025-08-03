var graph = new Dictionary<string, List<string>>
{
    { "A", new List<string> { "B", "C" } },
    { "B", new List<string> { "D" } },
    { "C", new List<string> { "E" } },
    { "D", new List<string>() },
    { "E", new List<string> { "F" } },
    { "F", new List<string>() }
};

var resultBFS = SolveGraphBFS(graph);
var resultDFS = SolveGraphDFS(graph.Keys.First() , graph , new HashSet<string>() , new List<string>());

foreach (var item in resultBFS)
{
    Console.WriteLine(item);
}

foreach (var item in resultDFS)
{
    Console.WriteLine(item);
}

static List<string> SolveGraphBFS(Dictionary<string, List<string>> dic)
{
    var startNode = dic.Keys.First();
    var visited = new HashSet<string>();
    var queue = new Queue<string>();
    var result = new List<string>();

    queue.Enqueue(startNode);

    while (queue.Count > 0)
    {
        var current = queue.Dequeue();

        if (!visited.Contains(current))
        {
            visited.Add(current);
            result.Add(current);

            if (dic.ContainsKey(current))
            {
                foreach (var item in dic[current])
                {
                    if (!visited.Contains(item))
                    {
                        queue.Enqueue(item);
                    }
                }
            }
        }
    }

    return result;
}

static List<string> SolveGraphDFS(string node, Dictionary<string, List<string>> graph, HashSet<string> visited, List<string> result)
{
    if (visited.Contains(node))
        return result;

    visited.Add(node);
    result.Add(node);

    if (graph.ContainsKey(node))
    {
        foreach (var neighbor in graph[node])
        {
            SolveGraphDFS(neighbor, graph, visited, result);
        }
    }

    return result;
}