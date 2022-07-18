using System;
using XadrezConsole.tabuleiro;
using XadrezConsole.xadrez;

namespace XadrezConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);
                    Console.WriteLine();
                    Console.Write("Origem, Coluna e Linha:  ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                    Console.WriteLine();
                    Console.Write("Destino, Coluna e Linha:  ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                Tela.ImprimirTabuleiro(partida.Tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
