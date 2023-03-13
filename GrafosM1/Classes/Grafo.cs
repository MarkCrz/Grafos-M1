namespace GrafosM1.Classes;

public class Grafo
{
    protected List<Vertice> vertices;
    protected bool direcionado;
    protected bool ponderado;

    protected Grafo(bool d, bool p)
    {
        direcionado = d;
        ponderado = p;
        vertices = new List<Vertice>();
    }

    protected bool InserirVerticeP(string label)
    {
        Vertice tempVertice = new Vertice(label);
        if (tempVertice != null)
        {
            vertices.Add(tempVertice);
            return true;
        }

        return false;
    }

    protected string labelVerticeP(int indice)
    {
        return vertices[indice].retornaLabel();
    }

    protected bool inserirArestaP(int o, int d, float p)
    {
        if (direcionado)
        {
            if (!ponderado)
            {
                vertices[o].AddAresta(o, d, 0);
            }
            if (ponderado)
            {
                vertices[d].AddAresta(o, d, p);
            }
        }
        else
        {
            if (!ponderado)
            {
                vertices[o].AddAresta(o, d, 0);
                vertices[d].AddAresta(d, o, 0);
            }
            if (ponderado)
            {
                vertices[o].AddAresta(o, d, p);
                vertices[d].AddAresta(d, o, p);
            }
        }

        return true;
    }
    
    protected void imprimeArestaP(int indexVertice, int indexAresta)
    {
        vertices[indexVertice].imprimeAresta(indexAresta);
    }

    protected bool existeArestaP(int origem, int destino)
    {
        return vertices[origem].existeArestaV(destino);
    }

    public float pesoAresta(int origem, int destino)
    {
        return vertices[origem].retornaPesoVertice(destino);
    }
    
    public int[] retornaVizinhos(int vertice)
    {
        int indexCorreto = vertice - 1;
        int[] tempArray = vertices[indexCorreto].retornaVizinhosV();
        return tempArray;
    }
}