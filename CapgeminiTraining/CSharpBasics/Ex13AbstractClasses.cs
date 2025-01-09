using System;

namespace CSharpBasics
{
    abstract class Account
    {
        public int AccountNo { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public void Credit(int amount) => Balance += amount;
        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Not possible");
            Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            double term = 0.25;
            double rateOfInterest = 0.065;
            var interest = this.Balance * term * rateOfInterest;
            Credit((int)interest);
        }
    }

    class RDAccount : Account
    {
        public override void CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }

    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }

    enum AccountType { SB, RD, FD }
    class AccountFactory
    {
        public static Account CreateAccount(AccountType accType)
        {
           Account acc = null; 
            switch (accType)
            {
                case AccountType.SB:
                    acc = new SBAccount();
                    break;
                case AccountType.RD:
                    acc = new RDAccount();
                    break;
                case AccountType.FD:
                    acc = new FDAccount();
                    break;
                default:
                    break;
            }
            return acc;
        }
    }
    internal class AbstractClassExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of Account from the values below:");
            var accTypes = Enum.GetValues(typeof(AccountType));
            foreach (var accType in accTypes)
            {
                Console.WriteLine(accType);
            }
            var type = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine(), true);
            var account = AccountFactory.CreateAccount(type);
            account.AccountNo = 123;
            account.AccountHolder = "Phaniraj";
            account.Credit(10000);
            account.CalculateInterest();
            Console.WriteLine($"The Current balance: {account.Balance}");
        }
    }
}
