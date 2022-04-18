using System;

namespace Lab2
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private DateTime _birth;

        public string Name { get { return _name; }  set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public DateTime Birthday { get { return _birth; } set { _birth = value; } }

        public int BirthdayYear
        {
            get { return _birth.Year; }

            set { _birth = new DateTime(value, _birth.Month, _birth.Day); }
        }

        public Person(string name, string surname, DateTime birth)
        {
            _name = name;
            _surname = surname;
            _birth = birth;
        }

        public Person()
        {
            _name = "New";
            _surname = "Person";
            _birth = DateTime.Now;
        }

        public override string ToString() => string.Format("{0} born {1}", ToShortString(), _birth);

        public virtual string ToShortString() => string.Format("{0} {1}", _name, _surname);

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            Person other = obj as Person;
            if (other == null)
                return false;

            return (other._name == _name && other._surname == _surname && other._birth == _birth);
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (person1 is null && person2 is null)
                return true;

            return Equals(person1, person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
