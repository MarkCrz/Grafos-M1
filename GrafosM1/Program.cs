// See https://aka.ms/new-console-template for more information

using GrafosM1.Classes;

    Console.WriteLine("Hello, World!");

    Matriz grafo = new Matriz(false, false);
    grafo.inserirVertice("Teste");
    grafo.inserirVertice("Teste 2");
    grafo.inserirAresta(0, 1, 0);
    grafo.imprimeGrafo();