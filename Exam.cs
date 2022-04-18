using System;

namespace Lab2
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
        
        public Exam(string subject, int mark, DateTime date)
        {
            Subject = subject;
            Mark = mark;
            Date = date;
        }

        public Exam()
        {
            Subject = "Math";
            Mark = 12;
            Date = DateTime.Now;
        }

        public override string ToString() => string.Format("{0} exam at {1}, mark: {2}", Subject, Date, Mark);
    }
}
