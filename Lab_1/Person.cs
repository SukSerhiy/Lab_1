using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public enum Gender { Male, Female}
    /// <summary>
    /// Людина
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// Прізвище, ім'я, по-батькові людини
        /// </summary>
        protected string name;
        /// <summary>
        /// Розклад занять для неї
        /// </summary>
        protected List<Subject> Rozklad;
        /// <summary>
        /// Стать
        /// </summary>
        public Gender gender;
        public string Name { get { return name; } }

        public abstract void VisitSubject(Subject subject);

        public override string ToString()
        {
            return name;
        }
    }
}
