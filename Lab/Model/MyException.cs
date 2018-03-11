using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Model
{
    class MyException : SystemException
    {
        string msg;
        public MyException(string m)
        {
            msg = m;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
