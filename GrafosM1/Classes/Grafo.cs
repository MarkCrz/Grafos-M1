namespace GrafosM1.Classes;

public class Grafo
{
    private List<Vertice> vertices;
    private bool direcionado;
    private bool ponderado;

    public Grafo(bool d, bool p)
    {
        direcionado = d;
        ponderado = p;
        vertices = new List<Vertice>();
    }

    public bool inserirVertice(string label)
    {
        Vertice tempVertice = new Vertice(label);
        if (tempVertice != null)
        {
            vertices.Add(tempVertice);
            return true;
        }

        return false;
    }

    public string labelVertice(int indice)
    {
        return vertices[indice].retornaLabel();
    }

    public bool inserirAresta(int o, int d, int p)
    {
        
        vertices[o].AddAresta(o, d, p);
        if (ponderado)
        {
            vertices[d].AddAresta(d, o, p);
        }

        return true;
    }
}