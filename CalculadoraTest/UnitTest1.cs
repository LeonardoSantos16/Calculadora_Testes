using Calculadora;
namespace CalculadoraTest
{
    public class UnitTest1
    {
        public Calculadora.Calculadora construirClasse()
        {
            Calculadora.Calculadora calc = new Calculadora.Calculadora("02/02/2020");
            return calc;
        }


        [Theory] //aplicar vários testes em apenas um método de teste
        [InlineData(1, 2, 3)] // valores dos parâmetros do método
        [InlineData(4, 5, 7)]
        public void TestSomar(int valor1, int valor2, int resultado)
        {
            Calculadora.Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.somar(valor1, valor2);
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(2, 4, 20)]
        [InlineData(3, 3, 9)]
        public void TesteMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora.Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(valor1, valor2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 4, 20)]
        [InlineData(3, 3, 1)]
        public void TesteDividir(int valor1, int valor2, int resultado)
        {
            Calculadora.Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.dividir(valor1, valor2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 4, 2)]
        [InlineData(3, 3, 0)]
        public void TesteSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora.Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(valor1, valor2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPorZero()        
        {
            Calculadora.Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(5,0)); 
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora.Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.somar(4, 4);
            calc.somar(2, 1);
            var lista = calc.historico();
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count());
        }
    }
}