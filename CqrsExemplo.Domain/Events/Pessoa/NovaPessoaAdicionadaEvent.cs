using CqrsExemplo.Domain.Core;

namespace CqrsExemplo.Domain
{
  public class NovaPessoaAdicionadaEvent : Event
  {
    public string Id { get; private set; }
    public string Nome { get; private set; }
    public string Documento { get; private set; }

    public NovaPessoaAdicionadaEvent(
      string id,
      string nome,
      string documento
    )
    {
        Id = id;
        Nome = nome;
        Documento = documento;
    }
  }
}