namespace Lab
{
    public interface Expression
    {
        int eval(IMyDictionary<string, int> dict);
    }
}