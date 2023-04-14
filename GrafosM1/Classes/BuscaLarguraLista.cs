namespace GrafosM1.Classes;

public class BuscaLarguraLista
{
    private Lista grafo;
    private List<ListaLargura> listaLarguras;
    private List<int> lista;

    public BuscaLarguraLista(Lista g)
    {
        grafo = g;
        listaLarguras = new List<ListaLargura>();
        lista = new List<int>();

        for (int i = 0; i < grafo.retornarQuantVertices(); i++)
        {
            ListaLargura l = new ListaLargura(i);
            listaLarguras.Add(l);
        }
    }
    

    public bool BuscarLarguraLista(int origem, int destino)
    {
        listaLarguras[origem].setarVisitado();
        lista.Add(origem);

        int index = origem;

        Vertice vertice;
        
        Console.Write("\nBuscando por largura: \n");
        
        while (lista.Count != 0)
        {
            index = lista[0];
            vertice = grafo.retornarVertice(index);
            lista.RemoveAt(0);
            Console.Write("- ");
            Console.Write(index + "\n");
            for (int i = 0; i < vertice.retornarQuantArestas(); i++)
            {
                if (listaLarguras[vertice.retornarDestino(i)].pegarVisitado() == false) 
                {
                    listaLarguras[vertice.retornarDestino(i)].setarVisitado();
                    lista.Add(vertice.retornarDestino(i));
                    Console.Write(vertice.retornarDestino(i) + " ");
                }

                if (vertice.retornarDestino(i) == destino)
                {
                    Console.Write("\nCaminho Encontrado!");
                    return true;
                }
            }
            listaLarguras[index].setarConferido();
            Console.Write("\n");
        }
        Console.Write("Não possui esse caminho!");
        return true;
    }
}