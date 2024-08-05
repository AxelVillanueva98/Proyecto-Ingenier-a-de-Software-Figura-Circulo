// .\test\Application.UnitTest\UnitTestCirculo.cs
using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestCirculo
    {
        [Theory]
        [InlineData(4, 25.132741228718345)]
        [InlineData(5, 31.41592653589793)]
        [InlineData(6, 37.699111843077517)]
        [InlineData(7, 43.982297150257104)]
        [InlineData(8, 50.26548245743669)]
        public void TestPerimetro(double radio, double PerimetroEsperado)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Circulo.Perimetro(radio); 
           
            // Assert – Verify
            Assert.Equal(PerimetroEsperado, resultado);
        }

        [Theory]
        [InlineData(4, 50.26548245743669)]
        [InlineData(5, 78.53981633974483)]
        [InlineData(6, 113.09733552923255)]
        [InlineData(7, 153.93804002589985)]
        [InlineData(8, 201.06192982974676)]
        public void TestArea(double radio, double AreaEsperada)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Circulo.Area(radio); 
           
            // Assert – Verify
            Assert.Equal(AreaEsperada, resultado);
        }
    }
}