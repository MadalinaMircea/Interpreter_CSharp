using System.Collections.Generic;
using System.Collections;

namespace Lab.Model.Utils
{
    public interface IMyList<T> : IEnumerable
    {
        void Add(T i);
    }
}