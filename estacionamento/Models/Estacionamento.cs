namespace estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Carro> veiculos = new List<Carro>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
           string placa =  Console.ReadLine();
            Carro carro = new Carro(placa);
            veiculos.Add(carro);
            Console.WriteLine("Veículo adicionado");


        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            if (veiculos.Any(v => v.Placa.ToUpper().Equals(placa.ToUpper()) ))
            {
                int horas = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = int.Parse(Console.ReadLine());


                decimal valorTotal = precoInicial + (precoPorHora * horas); 
                veiculos.RemoveAll(x => x.Placa.ToUpper().Equals(placa.ToUpper()));

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
            
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(Carro veiculo in veiculos) {
                    Console.WriteLine(veiculo.Placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}