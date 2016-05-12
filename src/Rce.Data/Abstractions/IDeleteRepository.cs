namespace Rce.Domain.Abstractions
{
    public interface IDeleteRepository<in T>
    {
        void Delete(T item);
    }
}