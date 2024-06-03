using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TDD;
using TDD.services;

namespace TDDTestes;


public class UnitTest1
{
    Calculadora calc = new Calculadora(); 

    [Fact] //teste da soma
    public void DeveSomar1Com2Retornando3()
    {
        int resultado = calc.Somar(1, 2);

        Assert.Equal(3, resultado);
    }

//---------------------------------------------------------------------------------//

    [Fact] //teste da subtração
    public void DeveSubtrair1de2Retornando1()
    {
        int resultado = calc.Substrair(2, 1);

        Assert.Equal(1, resultado);
    }

//---------------------------------------------------------------------------------//

    [Fact] //teste multiplicação
    public void DeveMultiplicar2Com2Retornando4()
    {
        int resultado = calc.Multiplicar(2, 2);

        Assert.Equal(4, resultado);
    }

//---------------------------------------------------------------------------------//

    [Fact] //teste dividir
    public void DeveDividir4por2Retornando2()
    {
        int resultado = calc.Dividir(4, 2);

        Assert.Equal(2, resultado);
    }

//---------------------------------------------------------------------------------//

    [Theory] //teste EhPar
    [InlineData(new int[] {2,4,6,8})]
    [InlineData(new int[] {1,3,5,7})]
    public void DeveVerificarSeOsNumerosSaoPar(int[] numeros)
    {
        foreach (var numero in numeros)
        {
            bool resultado = calc.EhPar(numero);
            if (numero % 2 == 0)
            {
                Assert.True(resultado, $"O número {numero} deveria ser par.");
            }
            else
            {
                Assert.False(resultado, $"O número {numero} deveria ser ímpar.");
            }
        }    
    }

//---------------------------------------------------------------------------------//

    [Theory] //teste NaoEhPar
    [InlineData(new int[] {2,4,6,8})]
    [InlineData(new int[] {1,3,5,7})]
    public void DeveVerificarSeOsNumerosSaoÍmpar(int[] numeros)
    {
        foreach (var numero in numeros)
        {
            bool resultado = calc.NaoEhPar(numero);
            if (numero % 2 == 0)
            {
                Assert.False(resultado, $"O número {numero} deveria ser par.");
            }
            else
            {
                Assert.True(resultado, $"O número {numero} deveria ser ímpar.");
            }
        }
    }

//---------------------------------------------------------------------------------//

    [Fact] //teste elevar ao quadrado
    public void DeveElevar3AoQuadradoRetornando9()
    {
        int resultado = calc.ElevarAoQuadrado(3);

        Assert.Equal(9, resultado);
    }

//---------------------------------------------------------------------------------//

    [Fact] //teste elevar ao cubo
    public void DeveElevar3AoCuboRetornando27()
    {
        int resultado = calc.ElevarAoCubo(3);

        Assert.Equal(27, resultado);
    }


}