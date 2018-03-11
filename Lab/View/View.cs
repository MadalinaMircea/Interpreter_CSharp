using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Model.Statements;
using Lab.Model.Utils;
using Lab.Model.ProgramState;
using Lab.Repository;
using Lab.Controller;
using Lab.Model;

namespace Lab.View
{
    class View
    {
        static void Main()
        {
            //v = 2; Print(v)
            Statement s1 = new CompoundStatement(new AssignStatement("v", new ConstantExpression(2)), new PrintStatement(
                new VariableExpression("v")));
            IMyStack<Statement> stack1 = new ExecStack<Statement>();
            stack1.Push(s1);
            IMyDictionary<string, int> dict1 = new SymbolTable<string, int>();
            Lab.Model.Utils.IMyList<int> list1 = new OutputList<int>();
            IFileTable<int, FileData> file1 = new FileTable<int, FileData>();
            PrgState p1 = new PrgState(dict1, list1, stack1, file1);
            IRepository repo1 = new Repository.Repository();
            repo1.AddPrgState(p1);
            Controller.Controller ctrl1 = new Controller.Controller(repo1);

            //a=2+3*5;b=a+1;Print(b)
            Statement s2 = new CompoundStatement(new CompoundStatement(new AssignStatement("a", new ArithmeticExpression(
                new ConstantExpression(2), new ArithmeticExpression(new ConstantExpression(3), new ConstantExpression(5),
                '*'), '+')), new AssignStatement("b", new ArithmeticExpression(new VariableExpression("a"),
                new ConstantExpression(1), '+'))), new PrintStatement(new VariableExpression("b")));
            IMyStack<Statement> stack2 = new ExecStack<Statement>();
            stack2.Push(s2);
            IMyDictionary<string, int> dict2 = new SymbolTable<string, int>();
            Lab.Model.Utils.IMyList<int> list2 = new OutputList<int>();
            IFileTable<int, FileData> file2 = new FileTable<int, FileData>();
            PrgState p2 = new PrgState(dict2, list2, stack2, file2);
            IRepository repo2 = new Repository.Repository();
            repo2.AddPrgState(p2);
            Controller.Controller ctrl2 = new Controller.Controller(repo2);

            //a=2-2;
            //(If a Then v = 2 Else v = 3);
            //Print(v)
            Statement s3 = new CompoundStatement(new AssignStatement("a", new ArithmeticExpression(new ConstantExpression(2),
                new ConstantExpression(2), '-')), new CompoundStatement(new IfStatement(new VariableExpression("a"),
                new AssignStatement("v", new ConstantExpression(2)), new AssignStatement("v", new ConstantExpression(3))),
                new PrintStatement(new VariableExpression("v"))));
            IMyStack<Statement> stack3 = new ExecStack<Statement>();
            stack3.Push(s3);
            IMyDictionary<string, int> dict3 = new SymbolTable<string, int>();
            Lab.Model.Utils.IMyList<int> list3 = new OutputList<int>();
            IFileTable<int, FileData> file3 = new FileTable<int, FileData>();
            PrgState p3 = new PrgState(dict3, list3, stack3, file3);
            IRepository repo3 = new Repository.Repository();
            repo3.AddPrgState(p3);
            Controller.Controller ctrl3 = new Controller.Controller(repo3);

            //openRFile(var_f,"test.in");
            //readFile(var_f, var_c); print(var_c);
            //(if var_c then readFile(var_f, var_c); print(var_c)else print(0));
            //closeRFile(var_f)

            Statement s4 = new CompoundStatement(new CompoundStatement(new OpenRFile("var_f", "E:\\Mada\\E\\School\\MAP\\RiderProjects\\Lab\\Lab\\test.txt"), 
                new ReadFile(new VariableExpression("var_f"), "var_c")), new CompoundStatement(new IfStatement(new VariableExpression("var_c"),
                new CompoundStatement(new ReadFile(new VariableExpression("var_f"), "var_c"), new PrintStatement(new VariableExpression
                ("var_c"))), new PrintStatement(new ConstantExpression(0))), new CloseRFile(new VariableExpression("var_f"))));
                
            IMyStack<Statement> stack4 = new ExecStack<Statement>();
            stack4.Push(s4);
            IMyDictionary<string, int> dict4 = new SymbolTable<string, int>();
            Lab.Model.Utils.IMyList<int> list4 = new OutputList<int>();
            IFileTable<int, FileData> file4 = new FileTable<int, FileData>();
            PrgState p4 = new PrgState(dict4, list4, stack4, file4);
            IRepository repo4 = new Repository.Repository();
            repo4.AddPrgState(p4);
            Controller.Controller ctrl4 = new Controller.Controller(repo4);

            TextMenu menu = new TextMenu();
            menu.addCommand(new ExitCommand("0", "exit"));
            menu.addCommand(new RunExample("1", s1.ToString() + '\n', ctrl1));
            menu.addCommand(new RunExample("2", s2.ToString() + '\n', ctrl2));
            menu.addCommand(new RunExample("3", s3.ToString() + '\n', ctrl3));
            menu.addCommand(new RunExample("4", s4.ToString() + '\n', ctrl4));
            menu.show();

            /*
            System.Console.WriteLine("Type: ");
            System.Console.WriteLine("'1':\n" + s1);
            System.Console.WriteLine("'2':\n" + s2);
            System.Console.WriteLine("'3':\n" + s3);
            System.Console.WriteLine("'4':\n" + s4);
            System.Console.Write("Your option: ");
            string opt = System.Console.ReadLine();
            bool ok = true;
            if (opt[0].Equals('1'))
                repo.AddPrgState(p1);
            else if (opt[0].Equals('2'))
                repo.AddPrgState(p2);
            else if (opt[0].Equals('3'))
                repo.AddPrgState(p3);
            else if(opt[0].Equals('4'))
                repo.AddPrgState(p4);
            else
            {
                System.Console.WriteLine("Incorrect");
                ok = false;
            }

            if (ok == true)
            {
                Controller.Controller ctrl = new Controller.Controller(repo);
                System.Console.WriteLine(repo.GetCurrent());
                try
                {
                    while (ok == true)
                    {
                        System.Console.WriteLine("Type:\n\t'1'- one step\n\t'2'- all steps\n\t'0'- exit");
                        System.Console.Write("Your option: ");
                        opt = System.Console.ReadLine();
                        if (opt[0].Equals('1'))
                            ctrl.OneStep();
                        else if (opt[0].Equals('2'))
                        {
                            ctrl.AllStep();
                            ok = false;
                        }
                        else if (opt[0].Equals('0'))
                            ok = false;
                        else
                            System.Console.WriteLine("Invalid option.");
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Exception");
                }
            }

            System.Console.WriteLine(repo.GetCurrent());

            System.Console.WriteLine("Press any button to exit.");
            System.Console.ReadKey();
           */
        }
    }
}
