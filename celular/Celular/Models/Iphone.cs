namespace Celular.Models
{
    public class Iphone(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        public override void InstalarAplicativo(string nome) {
        Console.WriteLine($"Instalando o aplicativo {nome} no iPhone");
       }
    }
}