namespace GrafosM1.Classes;

public class Djikstra
{
    private List<DjikstraClasse> djikstraClasses;
    private List<Vertice> a;
    private List<DjikstraClasse> q;
    private Lista grafo;

    public Djikstra(Lista g)
    {
        grafo = g;
        djikstraClasses = new List<DjikstraClasse>();
        for (int i = 0; i < g.retornarQuantVertices(); i++)
        {
            DjikstraClasse djikstraClasse = new DjikstraClasse(-1, g.retornarVertice(i));
            djikstraClasses.Add(djikstraClasse);
        }
        a = new List<Vertice>();
        q = djikstraClasses;
    }

    public int retornarIndex(string label)
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
        //}*/
        
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
    }

    public void retornarCaminho()
    {
        for (int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i].retornaLabel() + " ");
        }
    }
}