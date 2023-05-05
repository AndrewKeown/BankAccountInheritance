namespace BankAccountInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            BankAccount c = new BankAccount("ABC123", 100);
            b.Deposit(200);
            Console.WriteLine(b.ToString());
            Console.WriteLine($"You have just taken out: {b.Withdraw(300)}");
            Console.WriteLine(b.ToString());
            
        }
    }
}