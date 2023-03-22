namespace GradeAverageCalculator
{
    public class Grade
    {
        private const string A_PLUS = "A+";
        private const string A = "A";
        private const string A_MINUS = "A-";
        private const string B_PLUS = "B+";
        private const string B = "B";

        public decimal Score { get; }

        public Grade(decimal score)
        {
            Score = score;
        }

        public override string ToString() =>
            $"{Score} {FigureFromScore()}";

        public string FigureFromScore()
        {
            if(Score > 96)
            {
                return A_PLUS;
            }
            if (Score > 92)
            {
                return A;
            }
            if (Score > 89)
            {
                return A_MINUS;
            }
            if (Score > 86)
            {
                return B_PLUS;
            }
            if (Score > 82)
            {
                return B;
            }
            return string.Empty;
        }
    }
}
