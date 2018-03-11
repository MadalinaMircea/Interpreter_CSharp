using Lab.Model.Statements;
using Lab.Model.Utils;

namespace Lab.Model.ProgramState
{
    public class PrgState
    {
        private IMyDictionary<string, int> symbolTable;
        private IMyList<int> outputList;
        private IMyStack<Statement> execStack;
        private IFileTable<int, FileData> fileTable;

        public PrgState(IMyDictionary<string, int> symbolTable, IMyList<int> outputList, IMyStack<Statement> execStack,
            IFileTable<int, FileData> f)
        {
            this.symbolTable = symbolTable;
            this.outputList = outputList;
            this.execStack = execStack;
            fileTable = f;
        }

        public IFileTable<int, FileData> FileTable
        {
            get { return fileTable; }
            set { fileTable = value; }
        }

        public IMyDictionary<string, int> SymbolTable
        {
            get { return symbolTable; }
            set { symbolTable = value; }
        }

        public IMyList<int> OutputList
        {
            get { return outputList; }
            set { outputList = value; }
        }

        public IMyStack<Statement> ExecStack
        {
            get { return execStack; }
            set { execStack = value; }
        }

        public override string ToString()
        {
            return "\n\n\n" + execStack + symbolTable + outputList + "\n\n\n";
        }
    }
}