using System;

namespace CqrsExemplo
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