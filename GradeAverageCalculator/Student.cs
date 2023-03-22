using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverageCalculator
{
    public class Student
    {
        public string Name { get; }
        public List<int> TestResults { get; } = new List<int>();

        public Student(string name)
        {
            Name = name;
        }
        public void AddTestResult(int testResult) =>
            TestResults.Add(testResult);

        public decimal GetAverageScore() =>
            GetSum() / TestResults.Count;

        private decimal GetSum() =>
            (decimal)TestResults.Sum();
    }
}
