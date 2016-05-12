namespace Rce.Domain.Abstractions
{
    public interface IWriteRepository<in T> : IDeleteRepository<T>, IUpdateRepository<T>, ICreateRepository<T>
    {
    }
}