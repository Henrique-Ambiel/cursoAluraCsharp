using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//Screen Sound
string messageWelcome = "Bem vindo ao Screen Sound";

//Registrando bandas e suas 'notas através de listas e dicionários
//List<string> listBands = new List<string> {"U2", "Bon Jovi", "The Beatles"};
Dictionary<string, List<int>> dictionaryBands = new Dictionary<string, List<int>>();
dictionaryBands.Add("Linkin Park", new List<int>{10, 9, 10, 8, 10, 7});
dictionaryBands.Add("Bon Jovi", new List<int>());


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
        case 2: ViewBandsRegistered();
            break;
        case 3: EvaluateBand();
            break;
        case 4: BandAverage();
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
    ViewTitleOptions("REGISTRO DE BANDAS");
    Console.Write("\nDigite o nome da banda aqui: ");
    string bandName = Console.ReadLine()!;
    dictionaryBands.Add(bandName, new List<int>());
    Console.WriteLine($"\nA banda {bandName} foi registrada com sucesso");
    Thread.Sleep(4000);
    Console.Clear();
    DisplayMenuOptions();
}

//Exibe a lista com as bandas salvas
void ViewBandsRegistered()
{
    Console.Clear();
    ViewTitleOptions("BANDAS REGISTRADAS");
    //for (int i = 0; i < listBands.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listBands[i]}");
    //}
    foreach (string band in dictionaryBands.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }
    Console.WriteLine("\nDigite qualquer tecla para retornar");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

//Exibe o título de cada uma das opções
void ViewTitleOptions(string title)
{
   int numberOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numberOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

//Avaliar uma banda
void EvaluateBand()
{
    Console.Clear();
    ViewTitleOptions("AVALIAR BANDA");
    Console.Write("Digite a banda que você vai avaliar: ");
    string bandName = Console.ReadLine()!;
    if (dictionaryBands.ContainsKey(bandName))
    {
        Console.Write($"Digite aqui a nota da banda {bandName}: ");
        int grade = int.Parse(Console.ReadLine()!);
        dictionaryBands[bandName].Add(grade);
        Console.WriteLine($"\nNota {grade} registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine("Banda não encontrada\n");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        DisplayMenuOptions();
    }

}

//Média de avaliação das bandas
void BandAverage()
{
    Console.Clear();
    ViewTitleOptions("MÉDIA DAS BANDAS");
    Console.Write("Digite a banda que deseja ver a média: ");
    string bandName = Console.ReadLine()!;
    if (dictionaryBands.ContainsKey(bandName))
    {
        List<int> gradeBands = dictionaryBands[bandName];
        Console.WriteLine($"A média da banda {bandName} é: {gradeBands.Average()}");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine("Banda não encontrada\n");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();    
        DisplayMenuOptions();
    }
}

DisplayMenuOptions();

// Adicione esta linha para evitar que o console feche imediatamente
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();