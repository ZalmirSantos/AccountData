using System.Globalization;

namespace Account
{
    class AccountData
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public AccountData(int id, string name) 
        {
            Id = id;
            Name = name;
            Balance = 0.0;
        }
        public AccountData(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            Balance -= value + 5.00; 
        }
        public override string ToString()
        {
            return "Account " + Id + ", Holder: " + Name + ", Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
         

    }
}
