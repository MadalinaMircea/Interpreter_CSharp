using Lab.Model.ProgramState;
namespace Lab.Model.Statements
{
    public interface Statement
    {
        PrgState exec(PrgState p);
    }
}