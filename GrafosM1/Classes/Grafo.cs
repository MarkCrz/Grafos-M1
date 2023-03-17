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

    public bool removerAresta(int origem, int destino)
    {
        if (direcionado)
        {
            return vertices[origem].removerArestaV(destino);
        }
        else
        { 
            vertices[origem].removerArestaV(destino); 
            return vertices[destino].removerArestaV(origem);
        }
    }

    protected int retornaIndexVertice(string label)
    {
        for (var i = 0; i < vertices.Count; i++)
        {
            if (vertices[i].retornaLabel() == label)
            {
                return i;
            }
        }

        return -1;
    }

    public bool removerVertice(string label)
    {
        int index = retornaIndexVertice(label);
        
        Console.Write(index);
        for (var i = 0; i < vertices.Count; i++)
        {
            if (i != index)
            {
                if (vertices[i].existeArestaV(index))
                {
                    vertices[i].removerArestaV(index);
                }
            }
        }
        
        vertices[index].removerTodasArestas();
        vertices.RemoveAt(index);
        return true;
    }
}