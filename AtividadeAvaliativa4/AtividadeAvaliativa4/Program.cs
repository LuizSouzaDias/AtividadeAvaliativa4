using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem;
            bool repetir = true;
            Triangulo triangulo = new Triangulo();

            while (repetir)
            {
                Console.WriteLine("Digite o tamanho dos lados A, B e C do trinângulo");
                triangulo.setladoA(double.Parse(Console.ReadLine()));
                triangulo.setladoB(double.Parse(Console.ReadLine()));
                triangulo.setladoC(double.Parse(Console.ReadLine()));

                //Console.WriteLine("" + triangulo.getladoA() + triangulo.getladoB() + triangulo.getladoC()+ ""); testar set e get

                if(!verificaVazio(triangulo.getladoA(), triangulo.getladoB(), triangulo.getladoC()))
                {
                    mensagem = triangulo.verificaTriangulo();

                    Console.WriteLine(mensagem);

                    repetir = false;
                }
                else
                {
                    Console.WriteLine("\nDigite novamente os números, um dos lados digitados estão inválidos");
                    Console.WriteLine("");
                }

            }

        }

        static bool verificaVazio(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA <= 0 || ladoB <= 0 || ladoC <=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
