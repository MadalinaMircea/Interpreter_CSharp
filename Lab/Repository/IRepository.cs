using Lab.Model.ProgramState;

namespace Lab.Repository
{
    public interface IRepository
    {
        void AddPrgState(PrgState p);
        PrgState GetCurrent();
    }
}