// See https://aka.ms/new-console-template for more information

using GrafosM1.Classes;

    //Matriz matriz = new Matriz(true, false);
    //matriz.inserirVertice("Teste");
    //matriz.inserirVertice("Teste 2");
    //matriz.inserirVertice("Teste 3");
    //matriz.inserirAresta(0, 1, 0);
    //matriz.inserirAresta(0, 2, 0);
    //matriz.inserirAresta(1, 0, 0);
    //Console.Write("Existe aresta: " + matriz.existeAresta(1, 0) + "\n");
    
    //Console.Write("Vizinhos: ");
    //var vizinhos = matriz.retornaVizinhos(2);

    //foreach (var vizinho  in vizinhos)
    //{
    //    Console.Write(vizinho + " ");
    //}
    //Console.Write("\n");
    
    //Console.Write("Remover aresta: " + matriz.removerAresta(0, 2) + "\n");
    //Console.Write("Remover vertice: " + matriz.removerVertice("Teste") + "\n");
    
    //matriz.imprimeGrafo();


    //primeiro input para direcionada e segundo para ponderada
    //Lista lista = new Lista(false, false); 
    //lista.inserirVertice("Teste");
    //lista.inserirVertice("Teste 2");
    //lista.inserirVertice("Teste 3");
    //lista.inserirAresta(0, 1, 1);
    //lista.inserirAresta(0, 2, 1);
    //Console.Write("\nExiste aresta: " + lista.existeAresta(1, 0) + "\n");
    //Console.Write("Peso: " + lista.pesoAresta(0, 2));

    //Console.Write("\nVizinhos: ");
    //var vizinhos = lista.retornaVizinhos(1);

    //foreach (var vizinho  in vizinhos)
    //{
    //    Console.Write(vizinho + " ");
    //}

    //Console.Write("\n");
    
    //Console.Write("Remover aresta: " + lista.removerAresta(0, 2) + "\n");
    //Console.Write("Remover vertice: " + lista.removerVertice("Teste") + "\n"); 
    
    //lista.imprimeGrafo();
    
    Console.Write("\n\n");

    ArquivoTexto arquivoTexto = new ArquivoTexto("C:\\Users\\marco\\Documents\\GitHub\\Grafos-M1\\GrafosM1\\Leitura.txt" ,"C:\\Users\\marco\\Documents\\GitHub\\Grafos-M1\\GrafosM1\\Escrita.txt");

    Lista listaTxt = arquivoTexto.criarGrafoLista();

    listaTxt = arquivoTexto.inserirArestas(listaTxt);

    listaTxt.imprimeGrafo();

    listaTxt.verificarPlanaridade();

    ListaColoracao listaColoracao = new ListaColoracao();
    
    listaColoracao.ordernarVertices(listaTxt);
    listaColoracao.imprimirLista();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Resultado Welsh Powell: ");
    listaColoracao.welshPowell();
    Console.WriteLine("-----------------------------------");
    listaColoracao.imprimirLista();



/*BuscaLarguraLista buscaLarguraLista = new BuscaLarguraLista(listaTxt);
buscaLarguraLista.BuscarLarguraLista(1, 4);
Console.Write("\n\n");
BuscaProfundidade buscaProfundidade = new BuscaProfundidade(listaTxt);
buscaProfundidade.buscarProfundidade(1, 4);
Console.Write("\n\n");
Djikstra djikstra = new Djikstra(listaTxt);
djikstra.buscaDjikstra(1);;*/
    //djikstra.retornarCaminho();