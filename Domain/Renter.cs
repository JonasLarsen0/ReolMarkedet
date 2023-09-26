using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Domain
{
    public class Renter
    {
       

        public string Name
        { get; set; }

        public string Phonenumber
        { get; set; }

        public string Email
        { get; set; }

        public string BankAccountDetails
        { get; set; }

        public Renter(string name, string phonenumber, string email, string bankAccountDetails)
        {
            Name = name;
            Phonenumber = phonenumber;
            Email = email;
            BankAccountDetails = bankAccountDetails;
        }

              
    }
}
