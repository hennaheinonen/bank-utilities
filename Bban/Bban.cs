using System;
namespace Bban
{
    class Bban
    {
        public string Account { get; set; }
        public bool IsMachineNumber { get; set; }
        public string MachineNumber { get; set; }


        public Bban(string bban)
        {
            Account = bban;
            string tmpRefAccount = Account;
            IsMachineNumber = BankUtil.CorrectNumber(ref tmpRefAccount);
            MachineNumber = tmpRefAccount;
        }

        public bool IsValid()
        {
            return BankUtil.IsValidAccount(Account);
        }

        public override string ToString()
        {
            return $"BBAN: {Account}\n" +
                   $"MachineNumber: {MachineNumber}\n" +
                   $"IsValid: {IsMachineNumber}\n" +
                   $"--------------------------\n";

        }
    }
}