using Lab_1.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    //Студент
    class Student : Person
    {
        public Student(string name, Gender gender, List<Subject> Rozklad)
        {
            this.name = name;
            this.gender = gender;
            this.Rozklad = Rozklad;
        }

        public override void VisitSubject(Subject subject)
        {
            if (Rozklad.Where(s => s.ToString() == subject.ToString()).FirstOrDefault() != null)
            {
                StringBuilder message = new StringBuilder();
                switch (gender)
                {
                    case Gender.Male:
                        message.Append(String.Format("Студент {0} ", this));
                        message.Append("вiдвiдав ");
                        break;
                    case Gender.Female:
                        message.Append(String.Format("Студентка {0} ", this));
                        message.Append("вiдвiдала ");
                        break;
                    default:
                        break;
                }
                message.Append(String.Format("пару {0}", subject.ToString()));
                Console.WriteLine(message.ToString());
            }
            else
            {
                throw new SubjectOutOfRozkladException();
            }
        }
    }
}
