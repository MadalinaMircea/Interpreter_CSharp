using System;
using Lab.Model;

namespace Lab
{
    public class VariableExpression : Expression
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public VariableExpression(string n)
        {
            name = n;
        }
        
        public int eval(IMyDictionary<string, int> d)
        {
            if (!d.Contains(name))
                throw new MyException("Variable does not exist.");
            return d.Get(name);
        }

        public override string ToString()
        {
            return name;
        }
    }
}