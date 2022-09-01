using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Employee
    {
        private string _firstName {get; set; }
        private string _lastName {get; set; }
        private int _experienceYears {get; set; } = 0;
        private int _passedExamsCount {get; set; } = 0;

        public Employee(string fn, string ln, int years, int examsCount)
        {

            _firstName = fn;
            _lastName = ln;
            _experienceYears = years;
            _passedExamsCount = examsCount;
        }


        public int getIncomeSum(int startIncome)
        {
            int result = startIncome;
            if (_experienceYears > 5)
            {
              result = result + (startIncome*10/100);
            }

            if (_passedExamsCount > 10)
            {
                result = result + result*10/100;
            }
            return result;
        }
    }
}