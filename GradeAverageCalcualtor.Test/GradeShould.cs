using GradeAverageCalculator;

namespace GradeAverageCalcualtor.Test
{
    public class GradeShould
    {
        [Theory]
        [InlineData(99.8, "A+")]
        [InlineData(94.6,"A")]
        [InlineData(90.3, "A-")]
        [InlineData(87.2, "B+")]
        [InlineData(83.4, "B")]
        public void Be(decimal score, string expected)
        {
            var grade = new Grade(score);
            Assert.Equal(expected, grade.FigureFromScore());
        }
    }
}