using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//Screen Sound
string messageWelcome = "Bem vindo ao Screen Sound";

//Função de boas vindas ao aplicativo
void DisplayWelcomeMessage()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(messageWelcome);
}

//Função que exibe as opções do menu
void DisplayMenuOptions()
{
    Console.WriteLine("Tecle 1 para selecionar uma banda");
    Console.WriteLine("Tecle 2 para mostrar todas as bandas");
    Console.WriteLine("Tecle 3 para avaliar uma banda");
    Console.WriteLine("Tecle 4 paraexibir a média de uma banda");
    Console.WriteLine("Tecle -1 para sair");
}

DisplayWelcomeMessage();
DisplayMenuOptions();

// Adicione esta linha para evitar que o console feche imediatamente
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();