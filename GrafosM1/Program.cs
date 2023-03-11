// See https://aka.ms/new-console-template for more information

using GrafosM1.Classes;

Console.WriteLine("Hello, World!");

 Grafo grafo = new Grafo(false, false);
 grafo.inserirVertice("Teste");
 Console.Write(grafo.labelVertice(0));