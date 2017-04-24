using Lab_1.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    /// <summary>
    /// Викладач
    /// </summary>
    class Teacher : Person
    {
        public Teacher(string name, Gender gender, List<Subject> Rozklad)
        {
            this.name = name;
            this.gender = gender;
            this.Rozklad = Rozklad;
        }

        /// <summary>
        /// Викладач відвідав пару
        /// </summary>
        /// <param name="subject">Пара</param>
        /// <exception cref="Lab_1.MyExceptions.SubjectOutOfRozkladException">Якщо предмета немає в розкладі</exception>
        public override void VisitSubject(Subject subject)
        {
            if (Rozklad.Where(s => s.ToString() == subject.ToString()).FirstOrDefault() != null)
            {
                StringBuilder message = new StringBuilder(String.Format("Викладач {0} ", this));
                switch (gender)
                {
                    case Gender.Male:
                        message.Append("провiв ");
                        break;
                    case Gender.Female:
                        message.Append("провела ");
                        break;
                    default:
                        break;
                }
                message.Append(String.Format("пару {0}", subject.ToString()));
                Console.WriteLine(message.ToString());
            } else
            {
                throw new SubjectOutOfRozkladException();
            }
        }

    }
}
