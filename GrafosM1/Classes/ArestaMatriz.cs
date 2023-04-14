namespace GrafosM1.Classes;

public class ArestaMatriz
{
    private double peso;
    private int ligado;

    public ArestaMatriz(double p, int l)
    {
        peso = p;
        ligado = l;
    }

    public double retornarPeso()
    {
        return peso;
    }

    public int retornarLigacao()
    {
        return ligado;
    }

    public void inserirPeso(double p)
    {
        peso = p;
    }

    public void inserirLigacao(int l)
    {
        ligado = l;
    }
}