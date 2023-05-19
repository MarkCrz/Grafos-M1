namespace GrafosM1.Classes;

public class ArquivoTexto
{
    private StreamReader leitura;
    private StreamWriter escrita;

    public ArquivoTexto(string l, string e)
    {
        leitura = new StreamReader(l);
        escrita = new StreamWriter(e);
    }

    public Lista criarGrafoLista()
    {
        string linha = leitura.ReadLine();
        string[] dados = linha.Split(" ");
        int quantVertices = int.Parse(dados[0]);
        bool dir;
        bool pond;

        if (dados[2] == "0")
        {
            dir = false;
        }
        else
        {
            dir = true;
        }

        if (dados[3] == "0")
        {
            pond = false;
        }
        else
        {
            pond = true;
        }

        Lista tempLista = new Lista(dir, pond);

        for (int i = 0; i < quantVertices; i++)
        {
            tempLista.inserirVertice("" + i);
        }
        
        Console.Write("Lista criada com sucesso!\n");
        return tempLista;
    }

    public Lista inserirArestas(Lista lista)
    {
        string linha = leitura.ReadLine();
        string[] dados;
        int origem;
        int destino;
        double pond = 0;
        
        while (linha != null)
        {
            //Console.Write(linha + "\n");
            dados = linha.Split(" ");
            origem = int.Parse(dados[0]);
            destino = int.Parse(dados[1]);
            pond = 0;
            //Console.Write("Origem: " + dados[0] + "Destino: " + dados[1] + "Peso: " + dados[2]);

            if (dados.Length == 3)
            {
                pond = double.Parse(dados[2].Replace(".", ","));
            }
            
            lista.addQuantArestas();
            lista.inserirAresta(origem, destino, pond);
            linha = leitura.ReadLine();
        }

        Console.Write("Arestas criadas com sucesso!\n");
        return lista;
    }
}