using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace Entity.DBLayer.Model
{
    public class CustomersDatabaseModels
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
public class CategoriesModel
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

}
public class EmployeesModel
{
    public int EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Birthdate { get; set; }

    public string? Photo { get; set; }

    public string? Notes { get; set; }

}
public class OrderDetailsModel
{
    public int? OrderdetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }


}
public class OrdersModel
{
    public int Orderid { get; set; }

    public string? Orderdate { get; set; }

    public int? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShipperId { get; set; }

}
public class ProductsModel
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public string? Unit { get; set; }

    public string? Price { get; set; }

    public string? CategoryName { get; set; }


}
public class ShippersModel
{
    public int ShipperID { get; set; }
    public string? ShipperName { get; set; }
    public string? Phone { get; set; }
}
public class SuppliersModel
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? ContactName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

}




