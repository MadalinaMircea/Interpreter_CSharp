namespace Lab
{
    public class ConstantExpression : Expression
    {
        private int value;

        private int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public ConstantExpression(int v)
        {
            value = v;
        }

        public override string ToString()
        {
            return "" + value;
        }

        public int eval(IMyDictionary<string, int> d)
        {
            return value;
        }
    }
}