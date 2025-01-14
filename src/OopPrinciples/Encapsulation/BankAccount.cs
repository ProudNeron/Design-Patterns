namespace DesignPatterns.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal balance)
        {
            _balance = balance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposite(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit Amount could not be less or equal to 0");
            }

            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            } 
            else if (amount > _balance)
            {
                throw new InvalidOperationException("Withdraw amount must be less or equal to balance");
            }

            _balance -= amount;
        }
    }
}