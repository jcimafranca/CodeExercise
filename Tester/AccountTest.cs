using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
Using only NUnit's Assert.AreEqual method, write tests for the Account class that cover the following cases:

The Deposit and Withdraw methods will not accept negative numbers.
Account cannot overstep its overdraft limit.
The Deposit and Withdraw methods will deposit or withdraw the correct amount, respectively.
The Withdraw and Deposit methods return the correct results.

*/

[TestClass]
public class Tester
{        
    private double epsilon = 1e-6;

    [TestMethod]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);      

        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
    }
    [TestMethod]
    public void DepositDoNotAcceptNegativeAmount()
    {
        Account account = new Account(0);
        
        Assert.AreEqual(false, account.Deposit(-1));
    }
    [TestMethod]
    public void WithdrawDoNotAcceptNegativeAmount()
    {
        Account account = new Account(0);        

        Assert.AreEqual(false, account.Withdraw(-1));
    }
    [TestMethod]
    public void AccountCannotOverstepOverdraftLimit()
    {
        Account account = new Account(100);        

        Assert.AreEqual(false, account.Withdraw(101));
    }    
    [TestMethod]
    public void DepositCorrectResult()
    {
        Account account = new Account(0);        
        Assert.AreEqual(true, account.Deposit(50));
    }
    [TestMethod]
    public void WithdrawCorrectResult()
    {
        Account account = new Account(100);        
        Assert.AreEqual(true, account.Withdraw(50));
    }
    [TestMethod]
    public void DepositCorrectAmount()
    {
        double deposit = 50;
        Account account = new Account(0);

        Assert.AreEqual(true, account.Deposit(deposit));
        Assert.AreEqual(deposit, account.Balance);
    }
    [TestMethod]
    public void WithdrawCorrectAmount()
    {
        double withdraw = 50;
        Account account = new Account(100);

        Assert.AreEqual(true, account.Withdraw(withdraw));
        Assert.AreEqual(withdraw, account.OverdraftLimit + account.Balance);
    }
}