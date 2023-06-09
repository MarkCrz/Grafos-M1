namespace GrafosM1.Classes;

public class Matriz : Grafo
{
    public Matriz(bool d, bool p) : base(d, p)
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
        string tamCol = "- ";
        for (var i = 0; i < vertices.Count; i++)
        {
            tamCol = tamCol + (i + 1) + " ";
        }
        Console.Write(tamCol + "\n");
        
        for (var i = 0; i < vertices.Count; i++)
        {
            Console.Write((i + 1) + " ");
            vertices[i].imprimeArestasMatriz(vertices.Count);
            Console.Write("\n");
        }
    }

    public bool existeAresta(int origem, int destino)
    {
        return existeArestaP(origem, destino);
    }
}