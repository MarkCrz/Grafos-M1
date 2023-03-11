namespace GrafosM1.Classes;

public class Vertice
{
    private string label;
    private List<Aresta> arestas;

    public Vertice(string l)
    {
        label = l;
        arestas = new List<Aresta>();
    }

    public string retornaLabel()
    {
        return label;
    }

    public void AddAresta(int o, int d, int p)
    {
        Aresta tempAresta = new Aresta(o, d, p);
        arestas.Add(tempAresta);
    }
}