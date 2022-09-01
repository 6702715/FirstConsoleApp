// See https://aka.ms/new-console-template for more information
using FirstConsoleApp;

Console.WriteLine("Version 0.0.3");

int baseSalarySum = 0; //оклад
int incomeTax = 5;//% подоходного налога
int socialInsurance = 0; //% соц.страхования
int additionalSocialInsurance = 10;//% мед. страховка
int pensionFund = 5;//% в пенсионный фонд
int charityFees = 1;//% благотворительность

//for (int i = 0; i < 3; i++)
//{
    string? worker_fio = "<не указан>";
    // FIXME: Check value for empty string
    Console.Write("Введите ФИО сотрудника: ");
    string? s1 = Console.ReadLine();  
    if (!string.IsNullOrWhiteSpace(s1))
    {
        worker_fio = s1;
    }
    
    // TODO: Check empty first name and empty last name.
    string[] arr = worker_fio.Split(" ");
    string firstName = arr[0];
    string secondName = arr[1];

    Console.Write("Пожалуйста, для сотрудника <" + firstName + "" + secondName + "> введите сумму оклада: ");
    string? s2 = Console.ReadLine();

    if (int.TryParse(s2, out baseSalarySum))
    {
        Employee employee = new Employee(firstName, secondName,7,8);
        baseSalarySum = employee.getIncomeSum(baseSalarySum);
        socialInsurance = getSocialInsurance(baseSalarySum);
        int incomeTaxSum = incomeTax * baseSalarySum / 100;
        int socialInsuranceSum = socialInsurance * baseSalarySum / 100;
        int additionalSocialInsuranceSum = additionalSocialInsurance * baseSalarySum / 100;
        int pensionFundSum = pensionFund * baseSalarySum / 100;
        int charityFeesSum = charityFees * baseSalarySum / 100; ;//% благотворительность
        int sumAllFees = SumAllFees(incomeTaxSum, socialInsuranceSum, additionalSocialInsuranceSum, pensionFundSum, charityFeesSum);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("РАСЧЕТНАЯ ВЕДОМОСТЬ");
        Console.ResetColor();
        Console.WriteLine("ФИО сотрудника: " + worker_fio);
        Console.WriteLine("Оклад: " + baseSalarySum);
        Console.WriteLine("Подоходный налог ( " + incomeTax + "% ): " + incomeTaxSum);
        Console.WriteLine("Социальная страховка ( " + socialInsurance + "% ): " + socialInsuranceSum);
        Console.WriteLine("Мед. страховка ( " + additionalSocialInsurance + "% ): " + additionalSocialInsuranceSum);
        Console.WriteLine("Пенсионный фонд ( " + pensionFund + "% ): " + pensionFundSum);
        Console.WriteLine("Благотворительность ( " + charityFees + "% ): " + charityFeesSum);
        Console.WriteLine("");
        PrintInfo(sumAllFees, baseSalarySum - sumAllFees);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Веденна некорректная сумма оклада!");
        Console.ResetColor();
    }
//}

static int SumAllFees(int incomeTaxSum, int socialInsuranceSum, int additionalSocialInsuranceSum, int pensionFundSum, int charityFeesSum)
{
    return (incomeTaxSum + socialInsuranceSum + additionalSocialInsuranceSum + pensionFundSum + charityFeesSum);
}


static int getSocialInsurance(int baseSalarySum)
{
    int socialInsurance = 5;
    if (baseSalarySum >= 2000 && baseSalarySum < 5000)
    {
        socialInsurance = 10;
    }
    else if (baseSalarySum >= 5000)
    {
        socialInsurance = 35;
    }
    return socialInsurance;
}


static void PrintInfo(int sumAllFees, int salary)
{
    Console.WriteLine("Итого по налогам: " + sumAllFees);
    Console.WriteLine("Итого к выдаче: " + salary);
    Console.WriteLine("-----------------");
}