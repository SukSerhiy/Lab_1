using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.MyExceptions
{
    class SubjectOutOfRozkladException : Exception
    {
        public new string Message = "Цiєї пари немає в розкладi";
    }
}
