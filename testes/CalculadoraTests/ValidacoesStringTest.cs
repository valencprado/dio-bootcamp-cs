using Calculadora.Models;

namespace CalculadoraTests
{
    public class ValidacoesStringTest
    {
        private ValidacoesString _test;

        public ValidacoesStringTest()
        {
            _test = new ValidacoesString();
        }
        [Fact]
        public void DeveContarTresCaracteresEmOlaERetornarTres()
        {
            string palavra = "Olá";
            int contagem = _test.ContarCaracteres(palavra);
            Assert.Equal(3, contagem);
        }
    }
}