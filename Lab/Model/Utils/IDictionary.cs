using System.Collections;

namespace Lab
{
    public interface IMyDictionary<K,V> : IEnumerable
    {
        bool Contains(K k);
        V Get(K k);
        void Add(K k, V v);
        void Update(K k, V v);
    }
}