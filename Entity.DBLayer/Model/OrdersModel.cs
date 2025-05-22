using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DBLayer.Model
{
    public class OrdersModel
    {
        public int Orderid { get; set; }

        public string? Orderdate { get; set; }

        public int? CustomerId { get; set; }

        public int? EmployeeId { get; set; }

        public int? ShipperId { get; set; }
    }
}
