namespace Rce.Domain.Abstractions
{
    public interface IIdentifiableEntity<T>
    {
        T EntityId { get; set; }
    }
}