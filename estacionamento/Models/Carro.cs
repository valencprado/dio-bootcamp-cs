namespace estacionamento.Models
{
    public class Carro
    {
        public Carro(string placa) {
            this.Placa = placa;
        }
        public string Placa { get; set; }
    }
}