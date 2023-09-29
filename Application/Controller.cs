using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ReolMarkedet.Application
{
    public class Controller
    {
        public string ConnectionString;
        RenterRepository renterRepo;
        
        public Controller() 
        { renterRepo = new RenterRepository();
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            ConnectionString = config.GetConnectionString("MyDBConnection");
        }

        public void AddRenter(string name, string phoneNumber, string email, string bankAccountDetails)
        {
            renterRepo.CreateRenter(name, phoneNumber,email,bankAccountDetails );
        }
    }
}
