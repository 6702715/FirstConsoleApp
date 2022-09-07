using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Employee
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private int _experienceYears { get; set; } = 0;
        private int _passedExamsCount { get; set; } = 0;
        internal string Error { get; set; }

        public Employee(string fn, string ln, int years, int examsCount)
        {

            _firstName = fn;
            _lastName = ln;
            _experienceYears = years;
            _passedExamsCount = examsCount;
        }


        public int getIncomeSum(int startIncome)
        {
            if (startIncome <= 0)
            {
                Error = "Invalid value: <start income>";
                return -1;
            }

            if (_experienceYears < 0)
            {
                Error = "Invalid value: <years experience>";
                return -1;
            }

            if (_passedExamsCount < 0)
            {
                Error = "Invalid value: <number of exams passed>";
                return -1;
            }

            int result = startIncome;
            if (_experienceYears > 5)
            {
                result = result + (startIncome * 10 / 100);
            }

            if (_passedExamsCount > 10)
            {
                result = result + result * 10 / 100;
            }
            return result;
        }
    }
}