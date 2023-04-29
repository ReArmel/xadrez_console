using tabuleiro;
using xadrez_console;
using xadrez;
using xadrez_console.tabuleiro;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        try
        {
            Console.Clear();
            Tela.imprimirPartida(partida);

            Console.WriteLine();
            Console.Write("Digite a posição de origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.WriteLine();
            Console.Write("Digite a posição de destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
       
    }
    
}
catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();
