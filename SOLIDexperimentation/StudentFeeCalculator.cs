namespace SOLIDexperimentation
{
    public class StudentFeeCalculator : IStudentFees
    {
        public float BasicTution { get; set; } = 3500;
        public float DormFee { get; set; } = 3000;
        public float CafeteriaFee { get; set; } = 2250;

        public float AllFeesIncluded(double percentage)
        {
            var defaultFeeStructure = (BasicTution + DormFee + CafeteriaFee);
            if (percentage >= 75)
            {
                float temp = (float)(0.10 * defaultFeeStructure);
                float result = defaultFeeStructure - temp;
                return result;
            }
            else if (percentage >= 85)
            {
                float temp = (float)(0.15 * defaultFeeStructure);
                float result = defaultFeeStructure - temp;
                return result;
            }
            else if (percentage >= 95)
            {
                float temp = (float)(0.20 * defaultFeeStructure);
                float result = defaultFeeStructure - temp;
                return result;
            }
            return defaultFeeStructure;
        }
    }
}
