using System.Collections.Generic;
using Lab.Model.ProgramState;

namespace Lab.Repository
{
    public class Repository : IRepository
    {
        private List<PrgState> programs;
        private string filename;

        public Repository()
        {
            programs = new List<PrgState>();
            filename = "";
        }

        public Repository(string f)
        {
            programs = new List<PrgState>();
            filename = f;
        }

        private string Filename
        {
            get { return filename; }
        }

        public void AddPrgState(PrgState p)
        {
            programs.Add(p);
        }

        public PrgState GetCurrent()
        {
            return programs[0];
        }
    }
}