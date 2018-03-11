using System;
using Lab.Model;

namespace Lab
{
    public class ArithmeticExpression : Expression
    {
        private Expression e1, e2;
        private char oper;

        private Expression E1
        {
            get { return e1; }
            set { e1 = value; }
        }

        public override string ToString()
        {
            return "" + e1 + " " + oper + " " + e2;
        }

        private Expression E2
        {
            get { return e2; }
            set { e2 = value; }
        }

        public ArithmeticExpression(Expression expr1, Expression expr2, char op)
        {
            e1 = expr1;
            e2 = expr2;
            oper = op;
        }
        
        public int eval(IMyDictionary<string, int> d)
        {
            int v1 = e1.eval(d);
            int v2 = e2.eval(d);

            switch (oper)
            {
                case '+':
                    return v1 + v2;
                case '-':
                    return v1 - v2;
                case '*':
                    return v1 * v2;
                case '/':
                {
                    if (v2 == 0)
                        throw new MyException("Division by 0!");
                    return v1 / v2;
                }
                default:
                    throw new MyException("Invalid operator!");
            }
        }
    }
}