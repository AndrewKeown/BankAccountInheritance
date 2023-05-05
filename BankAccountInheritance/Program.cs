namespace BankAccountInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            CurrentAccount c = new CurrentAccount(500,500);
            
            Console.WriteLine(c.ToString());
            Console.WriteLine($"You have just taken out: {c.Withdraw(500)}");
            Console.WriteLine($"You have just taken out: {c.Withdraw(600)}");
            Console.WriteLine(c.ToString());
            
        }
    }
}