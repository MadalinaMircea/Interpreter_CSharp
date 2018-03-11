using System;
using System.IO;
using System.Runtime.CompilerServices;
using Lab.Model.ProgramState;
using Lab.Model.Utils;

namespace Lab.Model.Statements
{
    public class OpenRFile : Statement
    {
        private string varName;
        private string fname;
        private static int id = 0;

        public OpenRFile(string varName, string fname)
        {
            this.varName = varName;
            this.fname = fname;
        }

        public PrgState exec(PrgState state)
        {
            foreach (FileData i in state.FileTable)
                if (i.Name == fname)
                    throw new MyException("" + fname + " is already open");

            if (!File.Exists(fname))
                throw new MyException("" + fname + " does not exist");


            StreamReader sw = new StreamReader(fname, true);
            state.FileTable.add(id, new FileData(fname, sw));
            state.SymbolTable.Add(varName, id);
            id++;

            return state;

        }

        public override string ToString()
        {
            return "Open(" + fname + ")\n";

        }
    }
}