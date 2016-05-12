using System.Collections.Generic;

namespace Rce.Domain.Abstractions
{
    public interface IListRepository<out T>
    {
        IEnumerable<T> List();
    }
}