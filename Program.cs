namespace BankAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("Mostafa Ayman","12345678901234","01234567890","PortSaid",2);
            bankAccount1.ShowAccountData();
            BankAccount bankAccount2 = new BankAccount("Ahmed Atef", "67845678901234", "01204567890", "PortFoiad");
            bankAccount2.ShowAccountData();
            SavingAccount S1 = new SavingAccount("Mostafa Ayman", "12345678901234", "01234567890", "PortSaid", 2 );
            CurrentAccount S2 = new CurrentAccount("Ahmed Atef", "12345678901234", "01234567890", "PortSaid", 2);
            //S1.ShowAccountData();
            //S2.ShowAccountData();
            BankAccount[] accs = { S1, S2 };
            foreach(var i in accs)
            {
                i.ShowAccountData();
                Console.WriteLine($"Interset = {i.CalculateInterset()}");
            }

        }
    }
}
