// .\test\Application.IntegrationTest\IntegrationTestApplication.cs

using System;
using Xunit;
using Application;
namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 10, 502.6548245743669)]
    [InlineData(5, 15, 1178.0972450961724)]
    [InlineData(6, 20, 2261.9467105846511)]
    [InlineData(7, 25, 3848.4510006474961)]
    [InlineData(8, 30, 6031.8578948924023)]
    public void TestVolumen(double radio, double altura, double VolumenEsperado)
    {
        // Arrange – Set up            
        double area = Circulo.Area(radio); 
        // Act – Perform
        double resultado = Cilindro.Volumen(area, altura);
        // Assert – Verify
        Assert.Equal(VolumenEsperado, resultado);
    }
}