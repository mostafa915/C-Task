using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounting
{
     class SavingAccount:BankAccount
    {
        private decimal interestRate;
        public decimal InterestRate { get => interestRate; set => InterestRate = value; }
        public SavingAccount(string _fullName = "UnKnown", string _nationalId = "12345678900123", string _phoneNumber = "01124567890", string _address = "UnKnown", int _balance = 0 , decimal _interestRate = 1) : base(_fullName, _nationalId, _phoneNumber, _address, _balance) { 
            FullName = _fullName;
            NationalId = _nationalId;
            PhoneNumber = _phoneNumber;
            Address = _address;
            Balance = _balance;
            interestRate = _interestRate;
        }
        public override void ShowAccountData()
        {
            Console.WriteLine($"interestRate = {interestRate}");
            base.ShowAccountData();
        }
        public override double CalculateInterset()
        {
            return Balance * 0.05;
        }
    }
}
