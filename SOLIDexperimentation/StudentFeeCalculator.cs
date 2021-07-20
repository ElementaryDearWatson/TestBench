namespace SOLIDexperimentation
{
    public class StudentFeeCalculator : IStudentFees
    {
        public float BasicTution { get; set; } = 3500;
        public float DormFee { get; set; } = 3000;
        public float CafeteriaFee { get; set; } = 2250;

        public float AllFeesIncluded()
        {
            return (BasicTution + DormFee + CafeteriaFee);
        }
        public static float FiftenPercentScholarshipIncludedFee()
        {
            return 0;
        }
    }
}
