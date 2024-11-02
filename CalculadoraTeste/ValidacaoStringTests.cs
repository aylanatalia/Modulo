using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacaoStringTests
    {
        private ValidacaoString _validacao;
        public ValidacaoStringTests()
        {
            _validacao = new ValidacaoString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaRetornar3()
        {
            //Arrang
            string texto = "Ola";

            //Act
            int resultado = _validacao.ContarCaracteres(texto);

            //Asserts
            Assert.Equal(3, resultado);
        }
    }
}