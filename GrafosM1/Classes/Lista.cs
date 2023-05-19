namespace GrafosM1.Classes;

public class Lista : Grafo
{
    public Lista(bool d, bool p) : base(d, p)
    {
        direcionado = d;
        ponderado = p;
        vertices = new List<Vertice>();
        quantArestas = -1;
    }
    
    public bool inserirVertice(string label)
    {
        return InserirVerticeP(label);
    }

    public void addQuantArestas()
    {
        this.addContadorArestasG();
    }

    public int retornarQuantArestas()
    {
        return quantArestas;
    }
    
    public string labelVertice(int indice)
    {
        return labelVerticeP(indice);
    }
    
    public bool inserirAresta(int o, int d, double p)
    {
        return inserirArestaP(o, d, p);
    }
    
    public void imprimeAresta(int indexVertice, int indexAresta)
    {
        imprimeArestaP(indexVertice, indexAresta);
    }
    
    public void imprimeGrafo()
    {
        for (var i = 0; i < vertices.Count; i++)
        {
            Console.Write((i) + " - ");
            vertices[i].imprimeArestasLista(vertices.Count);
            Console.Write("\n");
        }
    }
    
    public bool existeAresta(int origem, int destino)
    {
        return existeArestaP(origem, destino);
    }

    public int retornarQuantVertices()
    {
        return vertices.Count;
    }

    public Vertice retornarVertice(int index)
    {
        return vertices[index];
    }

    public List<Vertice> retornarVertices()
    {
        return vertices;
    }

    public bool temCicloTres()
    {
        for (int i = 0; i < retornarQuantVertices(); i++)
        {
            var vizinhos = retornaVizinhos(i);
            foreach (var vizinho1 in vizinhos)
            {
                var vizinhos2 = retornaVizinhos(vizinho1);
                foreach (var vizinho2 in vizinhos2)
                {
                    Vertice temp = retornarVertice(i);
                    if (temp.existeArestaV(vizinho2))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public void verificarPlanaridade()
    {
        Console.WriteLine("V: " + retornarQuantVertices() + " A: " + retornarQuantArestas());
        if (retornarQuantVertices() <= 2)
        {
            Console.WriteLine("O grafo é planar!");
        }

        if (temCicloTres())
        {
            Console.WriteLine("O grafo possui ciclo de 3!");
            if (retornarQuantVertices() >= 3 && retornarQuantArestas() <= (3 * retornarQuantVertices()) - 6)
            {
                Console.WriteLine("O grafo pode ser planar!");
            }
            else
            {
                Console.WriteLine("O grafo pode não ser planar!");
            }
        }
        else
        {
            Console.WriteLine("O grafo não possui ciclo de 3!");
            if (retornarQuantVertices() >= 3 && retornarQuantArestas() <= (2 * retornarQuantVertices()) - 4)
            {
                Console.WriteLine("O grafo pode ser planar!");
            }
            else
            {
                Console.WriteLine("O grafo pode não ser planar!");
            }
        }
    }


}