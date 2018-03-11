using System.Collections;
using System.Collections.Generic;

namespace Lab.Model.Utils
{
    public interface IFileTable<K, V> : IEnumerable
    {
        void add(K key, V value);
        void delete(K key);
        bool exists(K key);
        V get(K key);
        void update(K key, V value);
        bool constainKey(K key);
        bool constainValue(V value);
    }
}