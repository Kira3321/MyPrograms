using System.Collections;

namespace Practice.MainScenario.IEnumerable;

public class Student
{
    public string Name { get; set; }
    public int[] Grades { get; set; }
}

public class StudentsCollection : IEnumerable<Student>
{
    private Student[] _student;

    public StudentsCollection(Student[] student)
    {
        _student = student;
    }

    public IEnumerator<Student> GetEnumerator() => new StudentEnumerator(_student);

    IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    protected class StudentEnumerator : IEnumerator<Student>
    {
        private Student[] _students;
        private int position = -1;
        public StudentEnumerator(Student[] students) => _students = students;

        public Student Current
        {
            get
            {
                if (position == -1 || position >= _students.Length) throw new ArgumentException();
                return _students[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < _students.Length;
        }

        public void Reset() => position = -1;

        object IEnumerator.Current => Current;


        public void Dispose()
        {
        }
    }
}