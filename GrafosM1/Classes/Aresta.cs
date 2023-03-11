namespace GrafosM1.Classes;

public class Aresta
{
    private int origem;
    private int destino;
    private int peso;

    public Aresta(int o, int d, int p)
    {
        origem = o;
        destino = d;
        peso = p;
    }
}