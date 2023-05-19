namespace GrafosM1.Classes;

public class ListaColoracao
{
    private List<Coloracao> coloracoes;

    public ListaColoracao(Lista lista)
    {
        coloracoes = new List<Coloracao>();
        ordernarVertices(lista);
    }

    private void ordernarVertices(Lista lista)
    {
        for (int i = 0; i < lista.retornarQuantVertices(); i++)
        {
            Vertice vTemp = lista.retornarVertice(i);
            Coloracao cT = new Coloracao(vTemp, vTemp.retornarQuantArestas());
            if (coloracoes.Count == 0)
            {
                coloracoes.Add(cT);
            }
            else
            {
                for (int j = 0; j < coloracoes.Count; j++)
                {
                    if (vTemp.retornarQuantArestas() >= coloracoes[j].getGrau())
                    {
                        coloracoes.Insert(j, cT);
                    }
                }
            }
        }
    }

    public void imprimirLista()
    {
        foreach (var coloracao in coloracoes)
        {
            Console.WriteLine("V: " + coloracao.getVerticeLabel() + "G: " + coloracao.getGrau() + "C: " + coloracao.getCor() + "S: " + coloracao.getSaturacao());
        }
        {
            
        }
    }
    
}