using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = null
            int n2 = null
            var operacao = null
            int resultado = null
                
            Console.WriteLine("Insira o primeiro número");
            Console.Readline(n1);
            Console.Writeline("insira o segundo numero");
            Console.Readline(n2);
            Console.Writeline("selecione a operação desejada");
            Console.Readline(operacao);
            
            if(operacao = +)
            {
            resultado = n1+n2;
            }
            
            if (operacao = -)
            {
            resultado = n1 - n2;
            }
            
            if (operacao = x)
            {
            resultado = n1 * n2;
            }
            
            if (operacao = /)
            {
                resultado = n1/n2;
            }
            
            else
            {
            Console.Writeline("operação inválida")
            }
            
            Console.Writeline("Resultado:", resultado)
        }
    }
}
