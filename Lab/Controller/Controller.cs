using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Lab.Model.Statements;
using Lab.Model.ProgramState;
using Lab.Model.Utils;
using Lab.Repository;
using System.IO;
using Lab.Model;

namespace Lab.Controller
{
    public class Controller
    {
        private IRepository repo;

        public Controller(IRepository r)
        {
            repo = r;
        }

        public void logState(PrgState state)
        {
            using (StreamWriter sw = File.AppendText("E:\\Mada\\E\\School\\MAP\\RiderProjects\\Lab\\Lab\\file.txt"))
            {
                sw.WriteLine(state.ExecStack);
                sw.WriteLine(state.SymbolTable);
                sw.WriteLine(state.OutputList);
                sw.WriteLine(state.FileTable);
                sw.WriteLine("\n\n");
            }
        }

        public void executeOneStep()
        {
            PrgState state = repo.GetCurrent();
            IMyStack<Statement> stack = state.ExecStack;

            Statement statement = stack.Pop();

            statement.exec(state);
            logState(state);
        }

        public void AllStep()
        {

            IMyStack<Statement> stack = repo.GetCurrent().ExecStack;

            while (!stack.IsEmpty())
                executeOneStep();

        }

    }
}