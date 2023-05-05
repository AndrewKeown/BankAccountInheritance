namespace BankAccountInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            BankAccount c = new BankAccount("ABC123", 100);

            Console.WriteLine(c.ToString());
        }
    }
}