using Lab.Model.ProgramState;

namespace Lab.Model.Statements
{
    public class AssignStatement : Statement
    {
        private string name;
        private Expression e;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AssignStatement(string name, Expression e)
        {
            this.name = name;
            this.e = e;
        }

        public override string ToString()
        {
            return "" + name + " = " + e + "\n" ;
        }

        public Expression E
        {
            get { return e; }
            set { e = value; }
        }
        public PrgState exec(PrgState p)
        {
            IMyDictionary<string, int> d = p.SymbolTable;
            int v = e.eval(d);
            if (d.Contains(name))
            {
                d.Update(name, v);
            }
            else
            {
                d.Add(name, v);
            }
            return p;
        }
    }
}