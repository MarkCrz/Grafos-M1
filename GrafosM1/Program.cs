// See https://aka.ms/new-console-template for more information

using GrafosM1.Classes;

    Matriz matriz = new Matriz(true, false);
    matriz.inserirVertice("Teste");
    matriz.inserirVertice("Teste 2");
    matriz.inserirVertice("Teste 3");
    matriz.inserirAresta(0, 1, 0);
    matriz.inserirAresta(0, 2, 0);
    matriz.inserirAresta(1, 0, 0);
    Console.Write("Existe aresta: " + matriz.existeAresta(1, 0) + "\n");
    
    Console.Write("Vizinhos: ");
    var vizinhos = matriz.retornaVizinhos(2);

    foreach (var vizinho  in vizinhos)
    {
        Console.Write(vizinho + " ");
    }
    Console.Write("\n");
    
   /* Console.Write("Remover aresta: " + matriz.removerAresta(0, 2) + "\n");
    Console.Write("Remover vertice: " + matriz.removerVertice("Teste") + "\n"); */
    
    matriz.imprimeGrafo();
    //primeiro input para direcionada e segundo para ponderada
    Lista lista = new Lista(false, false); 
    lista.inserirVertice("Teste");
    lista.inserirVertice("Teste 2");
    lista.inserirVertice("Teste 3");
    lista.inserirAresta(0, 1, 1);
    lista.inserirAresta(0, 2, 1);
    Console.Write("\nExiste aresta: " + lista.existeAresta(1, 0) + "\n");
    Console.Write("Peso: " + lista.pesoAresta(0, 2));

    Console.Write("\nVizinhos: ");
    vizinhos = lista.retornaVizinhos(1);

    foreach (var vizinho  in vizinhos)
    {
        Console.Write(vizinho + " ");
    }

    Console.Write("\n");
    
    Console.Write("Remover aresta: " + lista.removerAresta(0, 2) + "\n");
    Console.Write("Remover vertice: " + lista.removerVertice("Teste") + "\n"); 

    lista.imprimeGrafo();