using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    /// <summary>
    /// Предмет
    /// </summary>
    class Subject
    {
        private string name;
        private TimeSpan time;

        public Subject(string name)
        {
            this.name = name;
        }
        public Subject(string name, TimeSpan time)
        {
            this.name = name;
            this.time = time;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
