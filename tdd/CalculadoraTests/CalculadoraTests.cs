using Calculadora.Models;

namespace tdd;

public class CalculadoraTests
{
    private readonly CalculadoraClass _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraClass("12-12-2012");
    }

    [Theory]
    [InlineData(1, 2, 3)]
    public void Somar_NumeroTresEQuatro_DeveRetornarSete(int n1, int n2, int n3)
    {
       var resultado = _calc.Somar(n1, n2);

        Assert.Equal(n3, resultado);

    }   
    [Theory]
    [InlineData(5, 1, 4)]
    public void Subtrair_CincoEUm_DeveRetornarQuatro(int n1, int n2, int n3)
    {
       var resultado = _calc.Subtrair(n1, n2);

        Assert.Equal(n3, resultado);

    }   
    [Theory]
    [InlineData(1, 20, 20)]
    public void Multiplicar_UmEVinte_DeveRetornarVinte(int n1, int n2, int n3)
    {
       var resultado = _calc.Multiplicar(n1, n2);

        Assert.Equal(n3, resultado);

    }   
    [Theory]
    [InlineData(10, 5, 2)]
    public void Dividir_DezECinco_DeveRetornarDois(int n1, int n2, int n3)
    {
       var resultado = _calc.Dividir(n1, n2);

        Assert.Equal(n3, resultado);

    }

    [Fact]
    public void DividirPorZero() {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
    }

    [Fact]
    public void Historico() {
        _calc.Somar(1, 4);
        _calc.Somar(10, 10);
        _calc.Somar(23, 213134);
        _calc.Somar(5634, 124);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}