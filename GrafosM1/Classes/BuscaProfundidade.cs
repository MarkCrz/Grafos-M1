namespace GrafosM1.Classes;

public class BuscaProfundidade
{
    private Lista grafo;
    private List<ListaLargura> listaPro;
    private List<int> lista;
    
    public BuscaProfundidade(Lista g)
    {
        grafo = g;
        listaPro = new List<ListaLargura>();
        
        for (int i = 0; i < grafo.retornarQuantVertices(); i++)
        {
            ListaLargura l = new ListaLargura(i);
            listaPro.Add(l);
        }
    }

    private void dfs(int index, int dest)
    {
        Vertice vertice = grafo.retornarVertice(index);
        listaPro[index].setarVisitado();
       for (int i = 0; i < vertice.retornarQuantArestas(); i++)
       {
           Console.Write(vertice.retornarDestino(i) + " ");
           if (vertice.retornarDestino(i) == dest)
           {
               Console.Write("Caminho encontrado!\n");
           }
           if (listaPro[vertice.retornarDestino(i)].pegarVisitado() == false)
            {
                dfs(vertice.retornarDestino(i), dest);
            }
        }
        listaPro[index].setarConferido();
    }

    public bool buscarProfundidade(int origem, int destino)
    {
        Console.Write("Buscando por profundidade!\n");
        Console.Write(origem + " ");
        dfs(origem, destino);
        //if (encontrou == false)
        //{
        //    for (int i = 0; i < grafo.retornarQuantVertices(); i++)
        //    {
        //        if (listaPro[i].pegarConferido() == false)
        //        {
        //            Console.Write(i + " ");
        //            dfs(i, destino, encontrou);
        //        }
        //    }   
        //}
        return true;
    }
}