using System;
using System.IO;
using Lab.Model.ProgramState;

namespace Lab.Model.Statements
{
    public class ReadFile : Statement
    {
        private Expression exp;
        private string newVarName;

        public ReadFile(Expression exp, string newVarName)
        {
            this.exp = exp;
            this.newVarName = newVarName;
        }


        public PrgState exec(PrgState state)
        {
            int id = exp.eval(state.SymbolTable);
            StreamReader sw = state.FileTable.get(id).Sw;

            string line = sw.ReadLine();
            if (line == "")
                throw new MyException("Can not read line");


            int value = int.Parse(line);

            IMyDictionary<string, int> dict = state.SymbolTable;
            if(dict.Contains(newVarName))
                state.SymbolTable.Update(newVarName, value);
            else
                state.SymbolTable.Add(newVarName, value);

            return state;


        }

        public override string ToString()
        {
            return "ReadFile(" + exp + "," + newVarName + ")\n";
        }
    }
}