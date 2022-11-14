namespace CQRS.Core.Events;

public abstract class BaseEvent
{
    protected BaseEvent(string type)
    {
        Type = type;
    }
    public int Version { get; set; }
    public string Type { get; set; } = string.Empty;
}