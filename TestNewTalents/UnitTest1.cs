using NewTalents;
using System;
using Xunit;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2024";
            return new Calculadora(data);

        }
        [Theory]
        [InlineData(1,2, 3)]
        [InlineData(2,3, 5)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Somar(val1, val2);
            
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(9, 5, 4)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 3, 6)]
        public void TestMultipicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Multipicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(15, 3, 5)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.Somar(1,2);
            calc.Somar(1,3);
            calc.Somar(1,4);
            calc.Somar(1,5);

            var historico = calc.PegarHistorico();

            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);
        }
    }
}
