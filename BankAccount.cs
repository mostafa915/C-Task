using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounting
{
    class BankAccount
    {
        public const string bankCode = "BNK001";
        public readonly DateTime createdDate;
        private int accountNumber;
        private string fullName;
        private string nationalId;
        private string phoneNumber;
        private string address;
        private int balance;
        public string FullName
        {
            get => fullName; set
            {
                if (fullName != value)
                {
                    fullName = value;
                }
                else
                {
                    Console.WriteLine("Enter Name");
                }
            }

        }
        public string NationalId { get => nationalId; set {
                if(nationalId.Length == 14)
                {
                    nationalId = value;
                }
                else
                {
                    Console.WriteLine("You Must Enter 14 characters");
                }
            } 
        }
        public string PhoneNumber { get => phoneNumber; set { 
                if(phoneNumber.StartsWith("01") && phoneNumber.Length == 11)
                {
                    phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Phone Must Start With 0 and 1, Phone Must be Length = 11 ");
                }
            } 
        }
        public int Balance { get => balance; set { 
            if(balance >= 0)
                {
                    balance = value;
                }
            else
                {
                    Console.WriteLine("Balance Must Equal to zero or greater than zero ");
                }
            } 
        }
        public string Address { get => address; set => address = value; }
        public BankAccount()
        {
            createdDate = DateTime.Now;
            address = default;
            nationalId = default;
            phoneNumber = default;
            fullName = default;
            balance = default;
        }
        public BankAccount(string _fullName, string _nationalId, string _phoneNumber, string _address, int _balance):this()
        {
            fullName = _fullName;
            nationalId = _nationalId;
            phoneNumber = _phoneNumber;
            address = _address;
            balance = _balance;
            createdDate = DateTime.Now;

        }
        public BankAccount(string _fullName, string _nationalId, string _phoneNumber, string _address):this()
        {
            fullName = _fullName;
            nationalId= _nationalId;
            phoneNumber = _phoneNumber;
            address= _address;
            balance = 0;
            createdDate = DateTime.Now;
        }
        public virtual void ShowAccountData()
        {
            Console.WriteLine($"Account data: {fullName}, {nationalId}, {phoneNumber}, {balance}, {address}, {createdDate}");
        }
        public bool IsValidNationalID()
        {
            return nationalId.Length == 14;
        }
        public bool IsValidPhoneNumber()
        {
            return phoneNumber.Length == 11 && phoneNumber.StartsWith("01");
        }
        public virtual double CalculateInterset()
        {
            return 0;
        }
    }
}
