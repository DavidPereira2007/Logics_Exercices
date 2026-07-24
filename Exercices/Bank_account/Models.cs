////////////////////////////////////////
/// by: David de Sousa Pereira 24/07/2026
/// Code: Models for use em Application
////////////////////////////////////////
namespace Bank_account;
using System;
using System.Linq;

public class User
{
    private int id;
    private string ?name;
    private float Balance;

    public void CreateUser(string new_Name, float new_balance)
    {
        id = IdGenerator.GerarProximoId();
        name = new_Name;
        Balance = new_balance;
    }

    public int InfoId()
    {
        return id;
    }

    public float InfoBalance()
    {
        return Balance;
    }

    public void ModifyBalance(float number)
    {
        Balance += number;
    }

    public string InfoName()
    {
        if (!string.IsNullOrEmpty(name))
        {
            return name;
        }
        else
        {
            throw new ArgumentException("The name cannot be null or empty");
        }
        
    }
}

public class Account
{
   private int id;
    private string ?name;
    private float Balance_bank; 

    public void CreateAccount(User user)
    {
        id = user.InfoId();
        name = user.InfoName();
    }

    public int InfoId()
    {
        return id;
    }

    public float InfoBalance()
    {
        return Balance_bank;
    }

    public void ModifyBalance(float number)
    {
        Balance_bank += number;
    }

    public string InfoName()
    {
        if (!string.IsNullOrEmpty(name))
        {
            return name;
        }
        else
        {
            throw new ArgumentException("The name cannot be null or empty");
        }
        
    }
}

public class Bank
{
    private List<Account> accounts = new List<Account>();

    public bool ValidateAccount(User user)
    {
        return accounts.Any(x => x.InfoId() == user.InfoId());
    }

    public void InfoAccounts()
    {
        foreach (var ac in accounts)
        {
            Console.WriteLine(ac.InfoName());
            Console.WriteLine(ac.InfoBalance());
        }
    }

    public Account SearchAccount(User user)
    {
        var account = accounts.FirstOrDefault(x => x.InfoId() == user.InfoId());

        if (account != null)
        {
           return account; 
        }
        else
        {
            throw new ArgumentException("Account It doesn't exist.");
        }
         
    }

    public void RegisterAccount(User user)
    {
        // Verify if user he has account in bank
        
        if (ValidateAccount(user))
        {
            // it exists
        }
        else
        {
            // if not Create a new account
            Account account = new Account();
            account.CreateAccount(user);

            // register account in bank
            accounts.Add(account);
        }
        
    }

    public void Deposit(User user, float deposit)
    {
        if (ValidateAccount(user))
        {
            Account account = SearchAccount(user);

            if (account != null)
            {
                account.ModifyBalance(deposit);
                user.ModifyBalance(-deposit);

            }
            else
            {
                throw new ArgumentException("Account It doesn't exist.");
            }
        }
        else
        {
            throw new ArgumentException("User it's not registered");
        }
    }

    public void Withdraw(User user, float Withdraw)
    {
        if (ValidateAccount(user))
        {
            Account account = SearchAccount(user);

            if (account != null)
            {
                account.ModifyBalance(-Withdraw);
                user.ModifyBalance(Withdraw);

            }
            else
            {
                throw new ArgumentException("Account It doesn't exist.");
            }
        }
        else
        {
            throw new ArgumentException("User it's not registered");
        }
    }

    public void Transfer(User user, User user2, float transfer)
    {
        if (ValidateAccount(user))
        {
            Account account = SearchAccount(user);
            Account account2 = SearchAccount(user2);

            if (account != null && account2 != null)
            {
                account.ModifyBalance(-transfer);
                account2.ModifyBalance(transfer);
            }
            else
            {
                throw new ArgumentException("Account It doesn't exist.");
            }
        }
        else
        {
            throw new ArgumentException("User it's not registered");
        }
    }

}