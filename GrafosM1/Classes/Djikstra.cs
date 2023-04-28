namespace GrafosM1.Classes;

public class Djikstra
{
    private List<DjikstraClasse> djikstraClasses;
    private List<Vertice> vertices;
    //private List<DjikstraClasse> q;
    //private Lista grafo;

    public Djikstra(Lista g)
    {
        //grafo = g;
        djikstraClasses = new List<DjikstraClasse>();
        for (int i = 0; i < g.retornarQuantVertices(); i++)
        {
            DjikstraClasse djikstraClasse = new DjikstraClasse(Double.MaxValue, g.retornarVertice(i));
            djikstraClasses.Add(djikstraClasse);
        }
        vertices = new List<Vertice>();
        for (int i = 0; i < g.retornarQuantVertices(); i++)
        {
            vertices.Add(g.retornarVertice(i));
        }
        //q = djikstraClasses;
    }

    /*public int retornarIndex(string label)
    {
        int ind = 0;
        for (int i = 0; i < q.Count; i++)
        {
            if (q[i].retorarLabelVertice() == label)
            {
                ind = i;
            }
        }

        return ind;
    }
    
    public int extrairMinimaDistancia(int indVer)
    {
        double menorDistancia = -1;
        int index = indVer;

        Vertice vertice = djikstraClasses[index].retornarVertice();

        for (int i = 0; i < vertice.retornarQuantArestas(); i++)
        {
            if (menorDistancia == -1)
            {
                menorDistancia = vertice.retornarPesoDjikstra(i) + q[indVer].retornarDistancia();
                index = vertice.retornarDestinoDjikstra(i);
            }

            if (vertice.retornarPesoDjikstra(i) < menorDistancia && q[vertice.retornarDestinoDjikstra(i)].retornarDistancia() != -1 )
            {
                menorDistancia = vertice.retornarPesoDjikstra(i) + q[indVer].retornarDistancia();
                index = vertice.retornarDestinoDjikstra(i);
            }
            Console.Write(vertice.retornarPesoDjikstra(i));
        }
        Console.Write("Index: " + index);
        
        /*double menorDistancia = -1;
        Vertice vertice = djikstraClasses[indVer].retornarVertice();
        //Console.Write(vertice.retornarQuantArestas());
        int index = indVer;

        for (int i = 0; i < vertice.retornarQuantArestas(); i++)
        {
            //Console.WriteLine(i);
            if (menorDistancia == -1)
            {
                index = vertice.retornarDestinoDjikstra(i);
                //index = retornarIndex(vertice.retornaLabel());
                menorDistancia = q[index].retornarDistancia();
            }

            if ((q[index].retornarDistancia() < menorDistancia && q[indVer].retornarDistancia() != -1))
            {
                index = vertice.retornarDestinoDjikstra(i);
                menorDistancia = q[index].retornarDistancia();
            }
        }
        
        //for (int i = 0; i < vertice.retornarQuantArestas(); i++)
        //{
            //djikstraClasses[vertice.retornarDestinoDjikstra(i)].alterarDistancia(vertice.retornarPesoDjikstra(i));
            //if (vertice.retornarPesoDjikstra(i) < menorDistancia || menorDistancia == -1)
            //{
               // index = vertice.retornarDestinoDjikstra(i);
              //  menorDistancia = vertice.retornarPesoDjikstra(i);
            //}
        //}
        
        return index;
    }
    

    public void buscarDjikstra(int origem)
    {
        var index = origem;
        var veIn = origem;

        q[origem].alterarDistancia(0);
        
        
        //index = extrairMinimaDistancia(origem);
        
        while (q.Count != 0)
        {
            index = extrairMinimaDistancia(index);
            Console.WriteLine(index);
            Vertice v = q[index].retornarVertice();
            
            a.Add(v);
            for (int i = 0; i < v.retornarQuantArestas(); i++)
            {
                if (q[index].retornarDistancia() + q[i].retornarDistancia() < v.retornarPesoDjikstra(i))
                {
                    q[i].alterarDistancia(q[index].retornarDistancia() + q[i].retornarDistancia());
                }
            }

            veIn = veIn + 1;
            q.RemoveAt(index);
            
            
        }
    }*/

    public void retornarCaminho()
    {
        for (int i = 0; i < djikstraClasses.Count; i++)
        {
            Console.WriteLine("Vertice: " + i + " - Distancia: " + djikstraClasses[i].retornarDistancia());
        }
    }
    

    public void buscaDjikstra(int origem)
    {
        djikstraClasses[origem].alterarDistancia(0);
        while (true)
        {
            int visitado = -1;
            double menorDistancia = double.MaxValue;

            for (int i = 0; i < djikstraClasses.Count; i++)
            {
                if (!djikstraClasses[i].retornarVisitado() && djikstraClasses[i].retornarDistancia() < menorDistancia)
                {
                    visitado = i;
                    menorDistancia = djikstraClasses[i].retornarDistancia();
                }
            }
            
            if (visitado == -1)
            {
                break;
            }
            
            djikstraClasses[visitado].alterarVisitado();
            for (int i = 0; i < vertices[visitado].retornarQuantArestas(); i++)
            {
                int destino = vertices[visitado].retornarDestino(i);

                if (djikstraClasses[destino].retornarVisitado() == false)
                {
                    
                    double novaDistancia = djikstraClasses[visitado].retornarDistancia() + vertices[visitado].retornarPesoDjikstra(i);
                    if (novaDistancia < djikstraClasses[destino].retornarDistancia() || djikstraClasses[destino].retornarDistancia() == 0)
                    {
                        djikstraClasses[destino].alterarDistancia(novaDistancia);
                    }
                }
            }
            
        }
        
        retornarCaminho();
    }
}