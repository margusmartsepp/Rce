namespace Rce.Domain.Abstractions
{
    public interface IUpdateRepository<in T>
    {
        void Update(T item);
    }
}