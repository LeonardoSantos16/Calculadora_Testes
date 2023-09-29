using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> historicos;
        private string data;
        public Calculadora(string data)
        {
            this.data = data;
            historicos = new List<string>();
        }
        
        public int somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            historicos.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }
        public int subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            historicos.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }
        public int multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            historicos.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }
        public int dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            historicos.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }
        public List<string> historico()
        {
            historicos.RemoveRange(3, historicos.Count - 1);
            
            return historicos;
        }
    }
}
