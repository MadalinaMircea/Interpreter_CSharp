using System;
using System.Collections.Generic;
using System.Collections;
using System.Dynamic;

namespace Lab.Model.Utils
{
    public class SymbolTable<K,V> : IMyDictionary<K,V>
    {
        private Dictionary<K, V> dict;

        public SymbolTable()
        {
            dict = new Dictionary<K, V>();
        }

        public void Add(K k, V v)
        {
            dict[k] = v;
        }

        public void Update(K k, V v)
        {
            dict[k] = v;
        }

        public bool Contains(K k)
        {
            return dict.ContainsKey(k);
        }

        public V Get(K k)
        {
            if (dict.ContainsKey(k))
                return dict[k];
            throw new MyException("Variable does not exist.");
        }

        public override string ToString()
        {
            string text = "SymbolTable:\n";
            foreach (K k in dict.Keys)
                text = text + k + " --> " + dict[k] + '\n';
            return text;
        }

        public IEnumerator GetEnumerator()
        {
            return dict.GetEnumerator();
        }

    }
}