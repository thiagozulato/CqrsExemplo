using CqrsExemplo.Domain;
using Xunit;

namespace CqrsExemplo.Tests
{
    public class PessoaTests
    {
        [Fact]
        public void CriarNovaPessoaComSucesso()
        {
            var pessoa = new Pessoa("Usuario", "12345678909");

            Assert.False(pessoa.HasErrors());
            Assert.NotNull(pessoa.Id);
        }

        [Fact]
        public void AlterarNomeVazioDeveRetornarErro()
        {
            var pessoa = new Pessoa("Usuario", "12345678909");

            pessoa.AlterarNome(string.Empty);

            Assert.True(pessoa.HasErrors());
        }
    }
}