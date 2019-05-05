using System;
using MediatR;

namespace DDDExemplo
{
  public abstract class Event : INotification
  {
    public string EventId { get; private set; }
    public DateTime Timestamp { get; private set; }
    public string Name { get; private set; }

    public Event()
    {
        EventId = Guid.NewGuid().ToString();
        Timestamp = DateTime.Now;
        Name = GetType().Name;
    }
  }
}