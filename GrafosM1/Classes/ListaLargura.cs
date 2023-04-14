namespace GrafosM1.Classes;

public class ListaLargura
{
    private bool visitado;
    private int vertice;
    private bool conferido;

    public ListaLargura(int v)
    {
        visitado = false;
        vertice = v;
        conferido = false;
    }

    public void setarVisitado()
    {
        visitado = true;
    }

    public void setarVertice(int v)
    {
        vertice = v;
    }

    public void setarConferido()
    {
        conferido = true;
    }

    public bool pegarVisitado()
    {
        return visitado;
    }

    public int pegarVertice()
    {
        return vertice;
    }

    public bool pegarConferido()
    {
        return conferido;
    }
}