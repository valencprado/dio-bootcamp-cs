namespace CalculadoraTests;
using Calculadora.Models;
public class CalculadoraTests
{
    private CalculadoraImp calc;

    public CalculadoraTests()
    {
        calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomarUmComUmERetornarDois()
    {
        // arrange: montagem do cenário
        int n1 = 1;
        int n2 = 1;

        // act: chamar o teste
        int resultado = calc.Somar(n1, n2);

        // assert: validar o retorno
        Assert.Equal(2, resultado);

    }

    [Fact]
    public void DeveRetornarQue4EhPar()
    {
        int numero = 4;
        bool resultado = calc.EhPar(numero);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero) {
        bool resultado = calc.EhPar(numero);
        Assert.True(resultado);
    }
}