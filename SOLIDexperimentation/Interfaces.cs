namespace SOLIDexperimentation
{
    public interface IStudentMarksBasedOnSubjects
    {
        float SubjectA { get; set; }
        float SubjectB { get; set; }
        float SubjectC { get; set; }
        float SubjectD { get; set; }
        float CalculateAverageMarks();

        float StudentPrecentage();
    }
    public interface IStudentFees
    {
        float BasicTution { get; set; }
        float DormFee { get; set; }
        float CafeteriaFee { get; set; }
        float AllFeesIncluded(float percentage);

    }
}