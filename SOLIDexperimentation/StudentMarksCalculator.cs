namespace SOLIDexperimentation
{
    public class StudentMarksCalculator : IStudentMarksBasedOnSubjects
    {
        public float SubjectA { get; set; }
        public float SubjectB { get; set; }
        public float SubjectC { get; set; }
        public float SubjectD { get; set; }
        public float CalculateAverageMarks()
        {
            var temp = (SubjectA + SubjectB + SubjectC + SubjectD)/400;
            return temp;
        }
        public float StudentPrecentage()
        {
            var totalNumberOfMarks = CalculateAverageMarks();
            var temp = totalNumberOfMarks * 100 ;
            return temp;
        }
    }
}
