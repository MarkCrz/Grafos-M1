namespace GrafosM1.Classes;

public class Lista : Grafo
{
    public Lista(bool d, bool p) : base(d, p)
    {
        direcionado = d;
        ponderado = p;
        vertices = new List<Vertice>();
    }
    
    public bool inserirVertice(string label)
    {
        return InserirVerticeP(label);
    }
    
    public string labelVertice(int indice)
    {
        return labelVerticeP(indice);
    }
    
    public bool inserirAresta(int o, int d, float p)
    {
        return inserirArestaP(o, d, p);
    }
    
    public void imprimeAresta(int indexVertice, int indexAresta)
    {
        imprimeArestaP(indexVertice, indexAresta);
    }
    
    public void imprimeGrafo()
    {
        for (var i = 0; i < vertices.Count; i++)
        {
            Console.Write((i + 1) + " - ");
            vertices[i].imprimeArestasLista(vertices.Count);
            Console.Write("\n");
        }
    }
    
    public bool existeAresta(int origem, int destino)
    {
        return existeArestaP(origem, destino);
    }

    public int retornarQuantVertices()
    {
        return vertices.Count;
    }

    public Vertice retornarVertice(int index)
    {
        return vertices[index];
    }
    
    
}