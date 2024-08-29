using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4_cs_ex3
{

    /*Na mesma classe do exercício 03, crie um método que receba 3 valores, lados de
    um triângulo. O seu método deve verificar se os valores recebidos formam um
    triângulo.
    Se formarem um triângulo, calcular e escrever a área do triângulo formado e
    retornar este valor.
    Se não formarem um triângulo o seu método deve retornar o valor zero.
    Na classe Program testar também este novo método.*/

    public class Program
    {
        static void Main(string[] args)
        {
            Program start = new Program();
        }
        public Program()
        {
            Convert Converter = new Convert();
            List<string> listaS = new List<string>();
            List<double> listaD = new List<double>();
            List<string> listaS2 = new List<string>();
            List<double> listaD2 = new List<double>();
            int retorno;

            Console.WriteLine("Digite os 3 valores: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite o valor {0}/3: ", i + 1);
                listaS.Add(Console.ReadLine());
            }
            listaD = listaS.ConvertAll(double.Parse);
            Converter.Logica1(listaD);
            retorno = Converter.Logica2(listaD);
            if (retorno == 0)
            {
                Console.WriteLine("0 - Triângulo Retângulo");
            }
            else if (retorno == 1)
            {
                Console.WriteLine("1 - Triângulo Acutângulo");
            }
            else if (retorno == 2)
            {
                Console.WriteLine("2 - Triângulo Obtusângulo");
            }
            else
            {
                Console.WriteLine("Erro");
            }

            Console.ReadKey();
            Console.WriteLine("Exercicio 4");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite o valor {0}/3: ", i + 1);
                listaS2.Add(Console.ReadLine());
            }
            listaD2 = listaS2.ConvertAll(double.Parse);
            double area = Converter.Logica3(listaD2);
            Console.WriteLine("A área do triângulo é: {0}", area);
            Console.ReadKey();
        }
    }
}
