using tabuleiro;
using xadrez;
using Xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

 

    Tela.imprimirTabuleiro(partida.tab);

}
catch (TabuleiroException e)
{

   Console.WriteLine(e.Message);
}

Console.ReadLine();
