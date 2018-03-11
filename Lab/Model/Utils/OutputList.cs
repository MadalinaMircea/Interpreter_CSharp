using System.Collections;
using System.Collections.Generic;

namespace Lab.Model.Utils
{
    public class OutputList<T> : IMyList<T>
    {
        private List<T> output;

        public OutputList()
        {
            output = new List<T>();
        }
        public void Add(T t)
        {
            output.Add(t);
        }

        public override string ToString()
        {
            string text = "OutputList:\n";
            
            foreach (T t in output)
                text = text + t + '\n';
            
            return text;
        }

        public IEnumerator GetEnumerator()
        {
            return output.GetEnumerator();
        }
    }
}