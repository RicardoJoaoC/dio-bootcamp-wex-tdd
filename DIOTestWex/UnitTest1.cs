using Xunit;
using DIO_Bootcamp_Wex_TDD;

namespace DIOTestWex
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "10/06/2024";
            Calculadora calc = new Calculadora("10/06/2024");
            
            return calc;
        }
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadoraar = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadoraar);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 5, 1)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadoraar = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadoraar);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadoraar = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadoraar);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 2, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadoraar = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadoraar);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                    () => calc.Dividir(3, 0)
                );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1 , 2);
            calc.Somar(2 , 3);
            calc.Somar(3 , 4);
            calc.Somar(4 , 5);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}