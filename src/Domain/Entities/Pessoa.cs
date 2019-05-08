namespace CqrsExemplo
{
  public class Pessoa : Entity
  {
    public string Nome { get; private set; }
    public string Documento { get; private set; }

    public Pessoa(string nome, string document)
    {
        Nome = nome;
        Documento = document;
    }

    public void AlterarNome(string nome)
    {
      if (string.IsNullOrEmpty(nome)) AddNotification("Pessoa.Nome", "Nome inválido");
      
      Nome = nome;
    }
  }
}