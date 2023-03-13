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
    
    public void imprimeGrafo()
    {
        for (var i = 0; i < vertices.Count; i++)
        {
            vertices[i].imprimeArestas(i);
            Console.Write("\n");
        }
    }
}