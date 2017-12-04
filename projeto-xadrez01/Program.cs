using System;
using tabuleiro;

namespace projeto_xadrez01 {
    class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
