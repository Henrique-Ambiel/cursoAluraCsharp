using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//Screen Sound
string messageWelcome = "Bem vindo ao Screen Sound";

//Função de exibir a logo do aplicativo
void DisplayLogo()
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
    DisplayLogo();
    Console.WriteLine("Tecle 1 para selecionar uma banda");
    Console.WriteLine("Tecle 2 para mostrar todas as bandas");
    Console.WriteLine("Tecle 3 para avaliar uma banda");
    Console.WriteLine("Tecle 4 para exibir a média de uma banda");
    Console.WriteLine("Tecle -1 para sair");

    Console.Write("\nDigite aqui sua opção: ");
    string selectOption = Console.ReadLine()!;
    int selectNumericOption = int.Parse(selectOption);

    switch (selectNumericOption)
    {
        case 1: RegisterBand();
            break;
        case 2: Console.WriteLine("Você digitou a opção: " + selectOption);
            break;
        case 3: Console.WriteLine("Você digitou a opção: " + selectOption);
            break;
        case 4: Console.WriteLine("Você digitou a opção: " + selectOption);
            break;
        case -1: Console.WriteLine("Você saiu do programa!\nObrigado por testar");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

//Função de registrar uma banda
void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("REGISTRO DE BANDAS");
    Console.Write("Digite o nome da banda aqui: ");
    string bandName = Console.ReadLine()!;
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    DisplayMenuOptions();
}

DisplayMenuOptions();

// Adicione esta linha para evitar que o console feche imediatamente
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();