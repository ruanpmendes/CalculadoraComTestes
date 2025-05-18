using System;
using AulaTest;
using Xunit;

namespace AulaTestXunit
{
    public class CalculadoraTests
    {
        [Fact]
        public void TestarSoma()
        {
            Calculadora calc = new Calculadora();
            int total = calc.Somar(2, 2);
            Assert.Equal(4, total);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
        }
    }
}
