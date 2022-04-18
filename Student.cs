using System;
using System.Text;

namespace Lab2
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }

    internal class Student
    {
        private Person _person;
        private Education _education;
        private int _groupId;
        private Exam[] _passedExams;

        public Person Person { get { return _person; } set { _person = value; } }
        public Education Education { get { return _education; } set { _education = value; } }
        public int GroupId { get { return _groupId;} set { _groupId = value; } }
        public Exam[] PassedExams { get { return _passedExams; } set { _passedExams = value; } }

        public double MarkAverage
        {
            get
            {
                if (_passedExams.Length > 0)
                    return _passedExams.Average(x => x.Mark);
                else return 0;
            }
        }
            
        public Student(Person person, Education education, int groupId)
        {
            _person = person;
            _education = education;
            _groupId = groupId;
            _passedExams = new Exam[0];
        }

        public Student()
        {
            _person = new Person();
            _education = Education.SecondEducation;
            _groupId = 0;
            _passedExams = new Exam[0];
        }

        public void AddExams(params Exam[] exams)
        {
            _passedExams = _passedExams.Concat(exams).ToArray();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(ToShortString());

            if (_passedExams != null && _passedExams.Length > 0)
                foreach (var exam in _passedExams)
                    result.Append("\n" + exam);
            else result.Append("0 passed exams.");
            

            return result.ToString();
        }

        public virtual string ToShortString()
        {
            return string.Format("Student {0} with {1} education from {2} group. Passed exams: ", 
                _person, _education, _groupId);
        }
    }
}
