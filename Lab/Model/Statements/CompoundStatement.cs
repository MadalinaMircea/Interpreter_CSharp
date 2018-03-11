using Lab.Model.ProgramState;

namespace Lab.Model.Statements
{
    public class CompoundStatement : Statement
    {
        private Statement first;
        private Statement second;

        public CompoundStatement(Statement first, Statement second)
        {
            this.first = first;
            this.second = second;
        }

        public PrgState exec(PrgState state)
        {
            state.ExecStack.Push(second);
            state.ExecStack.Push(first);
            return state;
        }

        public override string ToString()
        {
            return "\n(\n" + first + "\n" + second + "\n)";
        }


    }
}