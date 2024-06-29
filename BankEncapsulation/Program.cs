namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            account.Deposit(700);

            Console.WriteLine(account.GetBalance());
        }
    }
}
