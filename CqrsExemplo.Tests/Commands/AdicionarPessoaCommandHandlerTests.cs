using System.Threading;
using System.Threading.Tasks;
using CqrsExemplo.Domain;
using MediatR;
using Xunit;

namespace CqrsExemplo.Tests
{
    public class AdicionarPessoaCommandHandlerTests
    {
        private readonly FakePessoaRepository fakePessoaRepository = new FakePessoaRepository();

        [Fact]
        public void AdicionarPessoaComSucesso()
        {
            var pessoaCommandHandler = new AdicionarPessoaCommandHandler(fakePessoaRepository, new FakeMediator());

            var result = pessoaCommandHandler.Handle(new AdicionarPessoaCommand
            {
                Nome = "Nova Pessoa",
                Documento = "12345678909"    
            }, CancellationToken.None).GetAwaiter().GetResult();

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public void DeveriaRetornarErroQuandoCommandForInvalido()
        {
            var pessoaCommandHandler = new AdicionarPessoaCommandHandler(fakePessoaRepository, new FakeMediator());

            var result = pessoaCommandHandler.Handle(new AdicionarPessoaCommand
            {
                Nome = "",
                Documento = "12345678909"    
            }, CancellationToken.None).GetAwaiter().GetResult();

            Assert.False(result.Success);
            Assert.Equal(1, result.Code);
            Assert.Null(result.Data);
        }
    }
}