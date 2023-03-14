using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa4
{
    internal class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public Triangulo() { }
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public double getladoA()
        {
            return this.ladoA;
        }
        public double getladoB()
        {
            return this.ladoB;
        }
        public double getladoC()
        {
            return this.ladoC;
        }

        public void setladoA(double ladoA)
        {
            this.ladoA = ladoA;
        }
        public void setladoB(double ladoB)
        {
            this.ladoB = ladoB;
        }
        public void setladoC(double ladoC)
        {
            this.ladoC = ladoC;
        }
        public string verificaTriangulo()
        {
            string mensagem;
            double ladoA, ladoB, ladoC;

            mensagem = "";

            ladoA = this.ladoA;
            ladoB = this.ladoB;
            ladoC = this.ladoC;

            if (ladoA >= ladoB + ladoC)
            {
                mensagem = "Não forma triângulo";
            }
            else if (ladoA == ladoB && ladoB == ladoC)
            {
                mensagem = "Trinângulo Equilátero";
            }
            else if ((ladoA * ladoA) == (ladoB * ladoB) + (ladoC * ladoC))
            {
                mensagem = "Triângulo Retângulo";
            }
            else if ((ladoA * ladoA) > (ladoB * ladoB) + (ladoC * ladoC))
            {
                mensagem = "Trinângulo Obstusângulo";
            }
            else if ((ladoA * ladoA) < (ladoB * ladoB) + (ladoC * ladoC))
            {
                mensagem = "Trinângulo Acutâno";
            }else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                mensagem = "Trinângulo Isósceles";
            }

            return mensagem;
        }


    }
}
