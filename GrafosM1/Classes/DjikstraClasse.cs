namespace GrafosM1.Classes;

public class DjikstraClasse
{
    private float distancia;
    private Vertice vertice;
    private bool visitado;


    public DjikstraClasse(float d, Vertice v)
    {
        distancia = d;
        vertice = v;
        visitado = false;
    }

    public void alterarDistancia(float d)
    {
        distancia = d;
    }

    public void alterarVisitado()
    {
        visitado = true;
    }

    public float retornarDistancia()
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
}