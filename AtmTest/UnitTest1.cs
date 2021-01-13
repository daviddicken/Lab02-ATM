using System;
using Xunit;
using Lab02_ATM;

namespace AtmTest
{
    public class UnitTest1
    {
        [Fact]
        public void ViewbalanceTest()
        {
            Assert.Equal(Program.Balance, Program.ViewBalance());
           
        }

        [Fact]
        public void WithdrawTest()
        {
            // Happy Path
            Program.Balance = 2000;
            Assert.Equal(1900, Program.Withdraw(100));
            
            // Test that you cannot withdraw too much
            Assert.Equal(1900, Program.Withdraw(20000));

            // Test that can not withdraw less then 0
            Assert.Equal(1900, Program.Withdraw(-100));
        }

        [Fact]
        public void DepositTest()
        {
            // Happy Path
            Program.Balance = 2000;
            Assert.Equal(2500, Program.Deposit(500));

            // Test if user tries to deposit less then 0
            Assert.Equal(2500, Program.Deposit(-500));
        }
    }
}
