using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraClass
    {
        private List<string> listaHistorico;
        private string data;
        public CalculadoraClass(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int n1, int n2)
        {
            
            var resultado = n1 + n2;
            listaHistorico.Insert(0, $"Resultado: {resultado} data - {data}");
            return resultado;

        }
        public int Subtrair(int n1, int n2)
        {
            int resultado =  n1 - n2;
            listaHistorico.Insert(0, $"Resultado: {resultado} data - {data}");
            return resultado;
        }
        public int Multiplicar(int n1, int n2)
        {
            int resultado =  n1 * n2;
            listaHistorico.Insert(0, $"Resultado: {resultado} data - {data}");
            return resultado;
        }
        public int Dividir(int n1, int n2)
        {
            int resultado =  n1 / n2;
            listaHistorico.Insert(0, $"Resultado: {resultado} data - {data}");
            return resultado;
        }
        public List<string> Historico() {
            
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}