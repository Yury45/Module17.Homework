namespace Module17.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount accountBase = new AccountBase() { Balance = 50200 };
            IAccount accountPayrolll = new AccountPayroll() { Balance = 2000 };

            Calculator.CalculateInterest(accountBase);
            Calculator.CalculateInterest(accountPayrolll);

            Console.WriteLine($"Параметр Interests обычного аккаунта: {accountBase.Interest}");
            Console.WriteLine($"Параметр Interests зарплатного аккаунта: {accountPayrolll.Interest}");
        }
    }
}