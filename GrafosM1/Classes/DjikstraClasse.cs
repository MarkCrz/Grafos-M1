namespace GrafosM1.Classes;

public class DjikstraClasse
{
    private double distancia;
    private Vertice vertice;
    private bool visitado;


    public DjikstraClasse(double d, Vertice v)
    {
        distancia = d;
        vertice = v;
        visitado = false;
    }

    public void alterarDistancia(double d)
    {
        distancia = d;
    }

    public void alterarVisitado()
    {
        visitado = true;
    }

    public double retornarDistancia()
    {
        return distancia;
    }

    public bool retornarVisitado()
    {
        return visitado;
    }

    public Vertice retornarVertice()
    {
        return vertice;
    }

    public string retorarLabelVertice()
    {
        return vertice.retornaLabel();
    }
}