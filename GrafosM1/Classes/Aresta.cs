namespace GrafosM1.Classes;

public class Aresta
{
    private int origem;
    private int destino;
    private float peso;

    public Aresta(int o, int d, float p)
    {
        origem = o;
        destino = d;
        peso = p;
    }

    public int retornaOrigem()
    {
        return origem;
    }

    public int retornaDestino()
    {
        return destino;
    }

    public float retornaPeso()
    {
        return peso;
    }

    public void imprimeAresta()
    {
        Console.Write("\nOrigem: " + origem + "\nDestino: " + destino + "\nPeso: " + peso + "\n");
    }
    
}