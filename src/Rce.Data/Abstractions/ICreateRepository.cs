namespace Rce.Domain.Abstractions
{
    public interface ICreateRepository<in T>
    {
        void Create(T item);
    }
}