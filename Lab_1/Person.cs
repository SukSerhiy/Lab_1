using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public enum Gender { Male, Female}
    abstract class Person
    {
        protected string name;
        protected List<Subject> Rozklad;
        public Gender gender;
        public string Name { get { return name; } }

        public abstract void VisitSubject(Subject subject);

        public override string ToString()
        {
            return name;
        }
    }
}
