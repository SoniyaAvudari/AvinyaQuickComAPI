using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DBLayer.Entities;
using Entity.DBLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity.DBLayer
{
    public class CustomerDatabaseClass : Interface
    {


        private readonly CustomersContext _customersContext;

        public CustomerDatabaseClass(CustomersContext customersContext)
        {

            _customersContext = customersContext;

        }

        public async Task<List<CategoriesModel>> GetAllCategories()
        {
            //LINQ Language Integrated Query

            var Categoryresult = await _customersContext.Categories.Select(
                 s => new CategoriesModel
                 {
                     CategoryId = s.CategoryId,
                     CategoryName = s.CategoryName,
                     Description = s.Description,

                 }
                   ).ToListAsync();
            return Categoryresult;
        }

        public async Task<List<CustomersModel>> GetAllCustomer()
        {
            //LINQ Language Integrated Query

            var Customerresult = await _customersContext.Customers.Select(
                 s => new CustomersModel
                 {
                     Customerid = s.CustomerId,
                     Customername = s.CustomerName,
                     Contactname = s.ContactName,
                     Address = s.Address,
                     City = s.City,
                     Postalcode = s.PostalCode,
                     Country = s.Country,

                 }
                   ).ToListAsync();
            return Customerresult;
        }

        public async Task<List<EmployeesModel>> GetAllEmployees()
        {
            //LINQ Language Integrated Query

            var Employeeresult = await _customersContext.Employees.Select(
                 s => new EmployeesModel
                 {
                     EmployeeId = s.EmployeeId,
                     FirstName = s.FirstName,
                     LastName = s.LastName,
                     Birthdate = s.Birthdate,
                     Photo = s.Photo,
                     Notes = s.Notes,

                 }
                   ).ToListAsync();
            return Employeeresult;
        }


        public async Task<List<OrderDetailsModel>> GetAllOrderDetails()
        {
            //LINQ Language Integrated Query

            var OrderDetailresult = await _customersContext.OrderDetails.Select(
                 s => new OrderDetailsModel
                 {
                     OrderdetailId = s.OrderId,
                     OrderId = s.OrderId,
                     ProductId = s.ProductId,
                     Quantity = s.Quantity,




                 }
                   ).ToListAsync();
            return OrderDetailresult;
        }


        public async Task<List<OrdersModel>> GetAllOrders()
        {
            //LINQ Language Integrated Query

            var Orderresult = await _customersContext.Orders.Select(
                 s => new OrdersModel
                 {
                     Orderid = s.Orderid,
                     Orderdate = s.Orderdate,
                     CustomerId = s.CustomerId,
                     EmployeeId = s.EmployeeId,
                     ShipperId = s.ShipperId,






                 }
                   ).ToListAsync();
            return Orderresult;
        }

        public async Task<List<ProductsModel>> GetAllProducts()
        {

            var Productresult = await _customersContext.Products
                 

                 .Select(
                  s => new ProductsModel
                  {
                      ProductId = s.ProductId,
                      ProductName = s.ProductName,
                      CategoryId = s.CategoryId,
                      SupplierId = s.SupplierId,
                      Price = s.Price,
                      Unit = s.Unit,

                  }
                    ).ToListAsync();
            return Productresult;
        }


        public async Task<List<ShippersModel>> GetAllShippers()
        {
            //LINQ Language Integrated Query

            var Shipperresult = await _customersContext.Shippers.Select(
                 s => new ShippersModel
                 {
                   ShipperID=s.ShipperId,
                   ShipperName=s.ShipperName,
                   Phone=s.Phone,

                 }
                 ).ToListAsync();
            return Shipperresult; 
        }




        public async Task<List<SuppliersModel>> GetAllSuppliers()
        {
            //LINQ Language Integrated Query

            var Supplierresult = await _customersContext.Suppliers.Select(
                 s => new SuppliersModel
                 {
                     SupplierId = s.SupplierId,
                     SupplierName = s.SupplierName,
                     ContactName = s.ContactName,
                     Address = s.Address,
                     City = s.City,
                     PostalCode = s.PostalCode,
                     Country = s.Country,
                     Phone = s.Phone,



                 }
                   ).ToListAsync();
            return Supplierresult;
        }
    }
}
        

      