using System;
using XadrezConsole.tabuleiro;

namespace XadrezConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Posicao posicao = new Posicao(3, 4);
            Console.WriteLine("Posição " + posicao);
        }
    }
}
