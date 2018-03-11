using System.Collections;

namespace Lab.Model.Utils
{
    public interface IMyStack<T> : IEnumerable
    {
        void Push(T t);
        T Pop();
        bool IsEmpty();
    }
}