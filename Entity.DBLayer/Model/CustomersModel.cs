using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace Entity.DBLayer.Model
{
    public class CustomersModel
    {
        public int Customerid { get; set; }

        public string? Customername { get; set; }

        public string? Contactname { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Postalcode { get; set; }

        public string? Country { get; set; }
    }
}

