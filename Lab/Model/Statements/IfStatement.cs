using Lab.Model.ProgramState;

namespace Lab.Model.Statements
{
    public class IfStatement : Statement
    {
        private Expression exp;
        private Statement thenStmt, elseStmt;

        public Expression Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public override string ToString()
        {
            return "if(" + exp + ")\nthen " + thenStmt + "\nelse " + elseStmt + "\n";
        }

        public Statement ThenStmt
        {
            get { return thenStmt; }
            set { thenStmt = value; }
        }

        public Statement ElseStmt
        {
            get { return elseStmt; }
            set { elseStmt = value; }
        }

        public IfStatement(Expression exp, Statement thenStmt, Statement elseStmt)
        {
            this.exp = exp;
            this.thenStmt = thenStmt;
            this.elseStmt = elseStmt;
        }

        public PrgState exec(PrgState p)
        {
            int v = exp.eval(p.SymbolTable);

            if (v != 0)
            {
                p.ExecStack.Push(thenStmt);
            }
            else
            {
                p.ExecStack.Push(elseStmt);
            }
            
            return p;
        }
    }
}