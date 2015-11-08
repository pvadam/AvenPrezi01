using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using BankAccount;

namespace BankAccount.Test
{
    public class BankAccountTest
    {
        [Fact]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Prepare
            // Mock<ILogger> mock = new Mock<ILogger>();
            // ILogger logger = mock.Object;
            ILogger logger = null;
            
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance, logger);
        
            // act
            account.Debit(debitAmount);
        
            // assert
            double actual = account.Balance;
        	Assert.True(actual.Equals(expected));
        }
        
        [Fact]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Prepare
            // Mock<ILogger> mock = new Mock<ILogger>();
            // ILogger logger = mock.Object;
            ILogger logger = null;
            
            // arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 16.54;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance, logger);
        
            // act
            account.Credit(creditAmount);
        
            // assert
            double actual = account.Balance;
        	Assert.True(actual.Equals(expected));
        }
    }
}
