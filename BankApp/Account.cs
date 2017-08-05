using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    /// <summary>
    /// This class describes the user's account
    /// </summary>
    class Account
    {
        #region static
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Email address of the user
        /// </summary>
        public string EmailAddress { get; set; }
        public int AccountNumber { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public double Salary { get; set; }
        //public double MonthlySalary { get;  set; }
        //public decimal Savings { get; private set; }
        //public decimal Needs { get; private set; }
        //public decimal Wants { get; private set; }

        #endregion
        #region constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }
        // overloading method - same name diff parameters
        // use 'this' for constructors only not methods
        //public Account(string emailAddress) : this()
        //{
        //    EmailAddress = emailAddress;
        //}
        //public Account(string emailAddress, double salary): this(emailAddress)
        //{
        //    Salary = salary;
        //}


        #endregion

    }
}
