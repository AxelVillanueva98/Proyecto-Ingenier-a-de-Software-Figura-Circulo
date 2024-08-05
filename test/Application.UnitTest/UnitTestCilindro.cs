// .\test\Application.UnitTest\UnitTestCilindro.cs
using System;
using Xunit;
using Application;
namespace Application.UnitTest;

public class UnitTestCilindro
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    [InlineData(34, 8, 272)]
    [InlineData(42, 10, 420)]
    [InlineData(51, 12, 612)]
    public void TestVolumen(double area, double altura, double VolumenEsperado)
    {
        // Arrange – Set up
      
        // Act – Perform
        double resultado = Cilindro.Volumen(area, altura);
        // Assert – Verify
        Assert.Equal(VolumenEsperado, resultado);
    }
}