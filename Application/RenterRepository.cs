using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ReolMarkedet.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ReolMarkedet.Application
{


    public class RenterRepository
    {
        
            public RenterRepository() 
        {
            
        }
    //connectionstring

    

    

         private List<Renter> renterList = new List<Renter>();
        //Add metode
        public void CreateRenter(string name, string phoneNumber, string Email, string bankAccountDetails)
        {
            //person er objektet
            //r er midlertidig person
            Renter r = new Renter(name, phoneNumber, Email, bankAccountDetails);
            renterList.Add(r);
        }
        
        
        


    }
}
