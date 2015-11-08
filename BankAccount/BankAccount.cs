using System;

namespace BankAccount
{
    /// <summary> 
    /// Bank Account demo class. 
    /// </summary> 
    public class BankAccount
    {
        private string m_customerName;

        private double m_balance;

        private bool m_frozen = false;
        
        private ILogger m_logger = null;

        private BankAccount(ILogger logger)
        {
            m_logger = logger;
        }

        public BankAccount(string customerName, double balance, ILogger logger)
        {
            m_customerName = customerName;
            m_balance = balance;
            m_logger = logger;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount; // intentionally incorrect code
            
            if (m_logger != null)
                m_logger.Info($"${amount.ToString()} debited.");
        }

        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
            
            if (m_logger != null)
                m_logger.Info($"${amount.ToString()} credited.");
        }

        private void FreezeAccount()
        {
            m_frozen = true;
        }

        private void UnfreezeAccount()
        {
            m_frozen = false;
        }
    }
}