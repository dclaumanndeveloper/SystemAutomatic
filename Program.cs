// See https://aka.ms/new-console-template for more information
using SystemAutomatic.Comands;

Console.WriteLine("");
string? comando;
comando = "";
while (!comando.Equals("Desligar"))
{
    comando = Console.ReadLine();
    Console.WriteLine(Commands.RetornoComando(comando));

}
