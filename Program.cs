using tabuleiro;
using xadrez_console;
using xadrez;
using xadrez_console.tabuleiro;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.WriteLine();
        Console.Write("Digite a posição de origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        Console.Write("Digite a posição de destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);
    }
    Tela.imprimirTabuleiro(partida.tab);
}
catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();
