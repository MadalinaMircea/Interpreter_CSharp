using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Model.Utils
{
    public class ExecStack<T> : IMyStack<T>
    {
        private Stack<T> stack = new Stack<T>();


        public void Push(T x)
        {
            stack.Push(x);
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public override string ToString()
        {
            string text = "Stack:\n";
            foreach (T t in stack)
                text = text + t ;
            return text;
        }

        public IEnumerator GetEnumerator()
        {
            return stack.GetEnumerator();
        }
    }
}