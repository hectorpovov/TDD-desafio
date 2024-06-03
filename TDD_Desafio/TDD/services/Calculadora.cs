using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD.services
{
    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public bool EhPar(int num1)
        {
            return num1%2 == 0;
        }

        public bool NaoEhPar(int num1)
        {
            return num1%2 != 0;
        }

        public int ElevarAoQuadrado(int num1)
        {
            return num1*num1;
        }
        public int ElevarAoCubo(int num1)
        {
            return num1*num1*num1;
        }
    }
}