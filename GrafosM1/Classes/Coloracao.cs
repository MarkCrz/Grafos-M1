namespace GrafosM1.Classes;

public class Coloracao
{
    private Vertice vertice;
    private int grau;
    private string cor;
    private int saturacao;

    public Coloracao(Vertice v, int g)
    {
        vertice = v;
        grau = g;
        cor = "Nenhuma";
        saturacao = 0;
    }

    public Vertice getVertice()
    {
        return vertice;
    }
    
    public string getVerticeLabel()
    {
        return vertice.retornaLabel();
    }

    public int getGrau()
    {
        return grau;
    }

    public void setarCor(string corTemp)
    {
        cor = corTemp;
    }

    public string getCor()
    {
        return cor;
    }

    public void setarSaturacao(int satTemp)
    {
        saturacao = satTemp;
    }

    public int getSaturacao()
    {
        return saturacao;
    }
}