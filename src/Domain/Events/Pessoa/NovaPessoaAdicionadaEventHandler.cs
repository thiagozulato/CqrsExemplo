using System;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MediatR;

namespace DDDExemplo {
  public class NovaPessoaAdicionadaEventHandler : INotificationHandler<NovaPessoaAdicionadaEvent>
  {
    public Task Handle(NovaPessoaAdicionadaEvent notification, CancellationToken cancellationToken)
    {
      Console.WriteLine("Nova Pessoa adicionada pelo Evento: {0}", JsonConvert.SerializeObject(notification));
      return Task.CompletedTask;
    }
  }
}