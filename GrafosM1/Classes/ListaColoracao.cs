namespace GrafosM1.Classes;

public class ListaColoracao
{
    private List<Coloracao> coloracoes;

    public ListaColoracao()
    {
        coloracoes = new List<Coloracao>();
    }

    public void ordernarVertices(Lista lista)
    {
        Vertice vTemp;
        
        for (int i = 0; i < lista.retornarQuantVertices(); i++)
        {
            vTemp = lista.retornarVertice(i);
            Coloracao cT = new Coloracao(vTemp, vTemp.retornarQuantArestas());
            if (coloracoes.Count == 0)
            {
                coloracoes.Add(cT);
            }
            else
            {
                inserirColoracao(vTemp, cT, coloracoes.Count);
            }
        }
    }

    private void inserirColoracao(Vertice v, Coloracao c, int t)
    {
        bool eMaior = true;
        for (int i = 0; i < t; i++)
        {
            if (v.retornarQuantArestas() >= coloracoes[i].getGrau() && v.retornaLabel() != coloracoes[i].getVerticeLabel())
            {
                coloracoes.Insert(i, c);
                eMaior = true;
                break;
            }
            else
            {
                eMaior = false;
            }
        }

        if (eMaior == false)
        {
            coloracoes.Add(c);
        }
    }

    public void imprimirLista()
    {
        foreach (var coloracao in coloracoes)
        {
            Console.WriteLine("V: " + coloracao.getVerticeLabel() + ", G: " + coloracao.getGrau() + ", C: " + coloracao.getCor() + ", S: " + coloracao.getSaturacao());
        }
    }
    
}