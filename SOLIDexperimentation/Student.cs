//Follow the Single Responsibility Principle
namespace SOLIDexperimentation
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }

        private readonly IStudentMarksBasedOnSubjects _studentMarksBasedOnSubjects;
        private readonly IStudentFees _studentFees;

        public Student(IStudentMarksBasedOnSubjects studentMarksBasedOnSubjects, IStudentFees studentFees)
        {
            _studentMarksBasedOnSubjects = studentMarksBasedOnSubjects;
            _studentFees = studentFees;
        }

        public float GetMarks(float A, float B, float C, float D)
        {
            _studentMarksBasedOnSubjects.SubjectA = A;
            _studentMarksBasedOnSubjects.SubjectB = B;
            _studentMarksBasedOnSubjects.SubjectC = C;
            _studentMarksBasedOnSubjects.SubjectD = D;

            return _studentMarksBasedOnSubjects.CalculateAverageMarks();
        }

        public float GetPercentage(float A, float B, float C, float D)
        {
            _studentMarksBasedOnSubjects.SubjectA = A;
            _studentMarksBasedOnSubjects.SubjectB = B;
            _studentMarksBasedOnSubjects.SubjectC = C;
            _studentMarksBasedOnSubjects.SubjectD = D;

            return _studentMarksBasedOnSubjects.StudentPrecentage();
        }

        public float GetTution(float percentage)
        {
            return _studentFees.AllFeesIncluded(percentage);
        }
    }
}
