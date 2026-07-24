////////////////////////////////////////
/// by: David de Sousa Pereira 24/07/2026
/// Code: Bank Service
////////////////////////////////////////

namespace Exercice;
using System;
using Bank_account;

public static class Bank_Service
{
    public static User Create_User(Bank bank, string name, float BalanceInitial)
    {
        if (string.IsNullOrEmpty(name) || BalanceInitial < 0)
        {
            throw new ArgumentException("The name cannot be null or empty, or BalanceInitial cannot be below zero"); 
        }
        else
        {
            User user = new User();
            user.CreateUser(name, BalanceInitial);

            // Register account in bank
            bank.RegisterAccount(user);
            return user;
        }
    }

    public static void Deposit_User(Bank bank,User user, float BalanceDeposit)
    {
        if (BalanceDeposit < 0 || BalanceDeposit >= 10000)
        {
            throw new ArgumentException("Check values"); 
        }

        bank.Deposit(user, BalanceDeposit);
    }

    public static void Withdraw_User(Bank bank, User user, float BalanceWithdraw)
    {
        if (BalanceWithdraw < 0 || BalanceWithdraw >= 5000)
        {
            throw new ArgumentException("Check values"); 
        }

        bank.Withdraw(user, BalanceWithdraw);
    }

    public static void Transfer_User(Bank bank, User user, User user2, float BalanceTransfer)
    {
        if (BalanceTransfer < 0 || BalanceTransfer >= 5000)
        {
            throw new ArgumentException("Check values"); 
        }

        bank.Transfer(user, user2, BalanceTransfer);
    }


}