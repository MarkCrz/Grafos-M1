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

    public void AddAresta(int o, int d, double p)
    {
        Aresta tempAresta = new Aresta(o, d, p);
        arestas.Add(tempAresta);
    }

    public void imprimeAresta(int index)
    {
        arestas[index].imprimeAresta();
    }

    public void imprimeArestasMatriz( int quantVertices)
    {
        bool possui = false;
        for (var i = 0; i < quantVertices; i++)
        {
            possui = false;
            for (var j = 0; j < arestas.Count; j++)
            {
                if (arestas[j].retornaDestino() == i)
                {
                    possui = true;
                    Console.Write("1 ");
                }
            }

            if (!possui)
            {
                Console.Write("0 ");
            }
            
        }
    }

    public void imprimeArestasLista(int quantVertices)
    {
        for (var i = 0; i < quantVertices; i++)
        {
            for (var j = 0; j < arestas.Count; j++)
            {
                if (arestas[j].retornaDestino() == i)
                {
                    Console.Write((arestas[j].retornaDestino()) + " ");
                }
            }
        }
    }

    public bool existeArestaV(int destino)
    {
        for (var i = 0; i < arestas.Count; i++)
        {
            if (arestas[i].retornaDestino() == destino)
            {
                return true;
            }
        }

        return false;
    }

    public double retornaPesoVertice(int destino)
    {
        double peso = 0;
        for (var i = 0; i < arestas.Count; i++)
        {
            if (arestas[i].retornaDestino() == destino)
            {
                peso = arestas[i].retornaPeso();
            }
        }

        return peso;
    }

    public int[] retornaVizinhosV()
    {
        int[] tempArray = new int[arestas.Count];
        for (var i = 0; i < arestas.Count; i++)
        {
            tempArray[i] = (arestas[i].retornaDestino() + 1);
        }

        return tempArray;
    }

    public bool removerArestaV(int destino)
    {
        for (var i = 0; i < arestas.Count; i++)
        {
            if (arestas[i].retornaDestino() == destino)
            {
                arestas.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public void removerTodasArestas()
    {
        for (var i = 0; i < arestas.Count; i++)
        {
            arestas.RemoveAt(i);
        }
    }

    public int retornarQuantArestas()
    {
        return arestas.Count;
    }

    public int retornarDestino(int i)
    {
        return arestas[i].retornaDestino();
    }

    public double retornarPesoDjikstra(int index)
    {
        return (arestas[index].retornaPeso());
    }

    public int retornarDestinoDjikstra(int index)
    {
        return arestas[index].retornaDestino();
    }
}