using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounting
{
     class CurrentAccount:BankAccount
    {
        private decimal overdraftLimit;
        public decimal OverdraftLimit { get => overdraftLimit; set => overdraftLimit = value; }
        public override void ShowAccountData()
        {
            Console.WriteLine($"overdraftLimit = {overdraftLimit}");
            base.ShowAccountData();
        }
        public CurrentAccount(string _fullName = "UnKnown", string _nationalId = "12345678900123", string _phoneNumber = "01124567890", string _address = "UnKnown", int _balance = 0 , decimal _overdraftLimit = 1) : base(_fullName, _nationalId, _phoneNumber, _address, _balance)
        {
            FullName = _fullName;
            NationalId = _nationalId;
            PhoneNumber = _phoneNumber;
            Address = _address;
            Balance = _balance;
            overdraftLimit = _overdraftLimit;
        }
    }
}
