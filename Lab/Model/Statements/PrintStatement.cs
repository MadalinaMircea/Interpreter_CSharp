using Lab.Model.ProgramState;

namespace Lab.Model.Statements
{
    public class PrintStatement : Statement
    {
        private Expression exp;

        public PrintStatement(Expression exp)
        {
            this.exp = exp;
        }

        public PrgState exec(PrgState state)
        {

            int result = exp.eval(state.SymbolTable);
            state.OutputList.Add(result);

            return state;
        }

        public override string ToString()
        {
            return "Print(" + exp + ")\n";
        }
    }
}