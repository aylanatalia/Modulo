using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;
    public  CalculadoraTests(){
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Asserts
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParRetornandoVerdadeiro()
    {
        //Arrenge
        int numero = 4;

        //Act 
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    //theory
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesRtornandoVerdadeiro(int numero)
    {
        //Arrange
        //Act
        bool resultado = _calc.EhPar(numero);
        //Assert
        Assert.True(resultado);

    }

    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6, 8, 10})]
    public void verificaSeOsNumerosSaoParERetornaVerdadeiro(int[] numero)
    {
        Assert.All(numero, num => Assert.True(_calc.EhPar(num)));
    }
}
