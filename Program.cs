using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                while (!partida.terminada) {

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoePossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoePossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
