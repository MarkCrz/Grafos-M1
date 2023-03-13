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

    public void AddAresta(int o, int d, float p)
    {
        Aresta tempAresta = new Aresta(o, d, p);
        arestas.Add(tempAresta);
    }

    public void imprimeArestas(int indexVertice)
    {
        for (var i = 0; i < arestas.Count; i++)
        {
            if (arestas[i].retornaOrigem() == indexVertice)
            {
                Console.Write("0 ");
            }

            if (arestas[i].retornaOrigem() == indexVertice && arestas[i].retornaDestino() == i)
            {
                Console.Write("1 ");
            }
        }
    }
}