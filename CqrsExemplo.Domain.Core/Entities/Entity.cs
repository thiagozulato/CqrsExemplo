using System;

namespace CqrsExemplo.Domain.Core
{
  public abstract class Entity : DomainNotification
  {
    public string Id { get; private set; }

    public Entity()
    {
      Id = Guid.NewGuid().ToString().Replace("-", "");
    }
  }
}