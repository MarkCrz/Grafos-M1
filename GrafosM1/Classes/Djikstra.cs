namespace GrafosM1.Classes;

public class Djikstra
{
    private List<DjikstraClasse> djikstraClasses;
    private List<int> a;
    private List<Vertice> q;
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
        a = new List<int>();
        q = g.retornarVertices();
    }

    public int extrairMinimaDistancia(int iV)
    {
        float menorDistancia = -1;
        Vertice vertice = djikstraClasses[iV].retornarVertice();
        Console.Write(vertice.retornarQuantArestas());
        int index = -1;
        
        for (int i = 0; i < vertice.retornarQuantArestas(); i++)
        {
            djikstraClasses[vertice.retornarDestinoDjikstra(i)].alterarDistancia(vertice.retornarPesoDjikstra(i));
            if (vertice.retornarPesoDjikstra(i) < menorDistancia || menorDistancia == -1)
            {
                index = vertice.retornarDestinoDjikstra(i);
                menorDistancia = vertice.retornarPesoDjikstra(i);
            }
        }
        
        return index;
    }
    
    

    public void buscarDjikstra(int origem)
    {
        int index = origem;
        
        
        Console.Write("Index Menor P: " + extrairMinimaDistancia(0));
        //while (q.Count != 0)
        //{
          //  index = extrairMinimaDistancia(origem);
            
            
        //}
    }
}