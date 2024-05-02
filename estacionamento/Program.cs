using estacionamento.Models;

int menu = 0;
decimal precoInicial = 0;
decimal precoPorHora = 0;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial:");
precoInicial =  Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço por hora:");
precoPorHora =  Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Digite uma opção válida");
            break;

    }
    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadKey();
}
