using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Model.ProgramState;

    namespace Lab.Model.Statements
    {
        public class CloseRFile : Statement
        {
            private Expression exp;

            public CloseRFile(Expression exp)
            {
                this.exp = exp;
            }

            public PrgState exec(PrgState state)
            {
                int id = exp.eval(state.SymbolTable);

                if (!state.FileTable.exists(id))
                    throw new MyException("This file" + exp + "can't be closed because do not exist");

                state.FileTable.get(id).Sw.Close();
                state.FileTable.delete(id);

                return state;
            }

            public override string ToString()
            {
                return "Close(" + exp + ")\n";
            }
        }
    }
