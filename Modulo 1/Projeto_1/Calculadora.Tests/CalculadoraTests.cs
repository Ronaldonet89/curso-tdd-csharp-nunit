﻿using NUnit.Framework;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        /* Teste Classe Adicionar 2 Números */
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            }

            /* Teste Classe Multiplicar 2 Números */
            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Multiplicar(5, 3);

                Assert.That(resultado, Is.EqualTo(15));
            }
        }

    }
}