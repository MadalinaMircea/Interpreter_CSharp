using System.Collections;
using System.Collections.Generic;

namespace Lab.Model.Utils
{
    public class FileTable<K, V> : IFileTable<K,V>
    {
        Dictionary<K, V> fileTable = new Dictionary<K, V>();

        public void add(K key, V value)
        {
            fileTable[key] = value;
        }

        public void delete(K key)
        {
            fileTable.Remove(key);
        }

        public bool exists(K key)
        {
            return fileTable.ContainsKey(key);
        }

        public V get(K key)
        {
            return fileTable[key];
        }

        public void update(K key, V value)
        {
            fileTable[key] = value;
        }

        public bool constainKey(K key)
        {
            return fileTable.ContainsKey(key);
        }

        public bool constainValue(V value)
        {
            return fileTable.ContainsValue(value);
        }

        public IEnumerable allValues()
        {
            return fileTable.Values;
        }

        public IEnumerator GetEnumerator()
        {
            return fileTable.GetEnumerator();
        }

        public override string ToString()
        {
            string text = "FileTable:\n";
            foreach (K k in fileTable.Keys)
                text = text + k + " --> " + fileTable[k] + '\n';
            return text;
        }
    }
}