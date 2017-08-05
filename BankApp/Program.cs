using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account
            {
                EmailAddress = "user1@mail.com",
                Salary = 70000
        };

            Console.WriteLine(
                        $"Account Number: {myAccount.AccountNumber}," +
                        $"Email Address: { myAccount.EmailAddress}," +
                        $"Account Creation Date: { myAccount.CreatedDate}," +
                        $"Salary: { myAccount.Salary:c}");
            Console.WriteLine(
                "According to your salary, your budget should be : " +
                "Savings: {0}, " +
                "Wants: {1}, " +
                "Needs: {2}", 
                (myAccount.Salary /12) *0.3, 
                (myAccount.Salary/12) * 0.5, 
                (myAccount.Salary/12 )* 0.2
                );

            //var myAccount2 = new Account();
            //myAccount2.EmailAddress = "user2@mail.com";
            //myAccount2.Salary = 25000;

            //Console.WriteLine(
            //            $"Account Number: {myAccount2.AccountNumber}," +
            //            $"Email Address: { myAccount2.EmailAddress}," +
            //            $"Account Creation Date: { myAccount2.CreatedDate}," +
            //            $"Salary: { myAccount2.Salary:c}");

             Console.ReadKey();
        }
    }
}
