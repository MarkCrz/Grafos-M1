using System.Diagnostics;

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
    
    private string getCorVerticeLabel(string label)
    {
        string cor = "Nenhuma";
        foreach (var coloracao in coloracoes)
        {
            if (coloracao.getVerticeLabel() == label)
            {
                return coloracao.getCor();
            }
        }

        return cor;
    }

    private bool vizinhosCor(string cor, Vertice vertice)
    {
        bool verificador = true;
        for (int i = 0; i < vertice.retornarQuantArestas(); i++)
        {
            if (getCorVerticeLabel(vertice.retornarDestino(i).ToString()) == cor)
            {
                verificador = true;
                break;
            }
            else
            {
                verificador = false;
            }
        }
        return verificador;
    }

    public void welshPowell()
    {
        var pintado = 0;
        var quantCores = 0;
        string[] cores = { "Verde", "Azul", "Amarelo", "Vermelho", "Roxo" };
        var sw = new Stopwatch();
        sw.Start();

        while (pintado < coloracoes.Count)
        {
            for (int i = 0; i < cores.Length; i++)
            {
                foreach (var coloracao in coloracoes)
                {
                    if (coloracao.getCor() == "Nenhuma")
                    {
                        if (vizinhosCor(cores[i], coloracao.getVertice()) == false)
                        {
                            coloracao.setarCor(cores[i]);
                            pintado++;
                            quantCores = i + 1;
                        }
                    }
                }   
            }
        }
        sw.Stop();
        Console.WriteLine("Quantidade de cores utilizada: " + quantCores);
        Console.WriteLine("Tempo gasto: " + sw.Elapsed);
    }
    
}