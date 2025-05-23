using System.Data.Common;
using Entity.DBLayer;
using Entity.DBLayer.Model;

namespace QuickCom.BussinessLayer
{
    public class CustomersBusiness : ICustomersBusiness
    {
        private readonly ICustomersDB _iCustomersDB;

        public CustomersBusiness(ICustomersDB iCustomersDB)
        {
            _iCustomersDB = iCustomersDB;
        }


        public Task<List<CategoriesModel>> GetAllCategories()
        {
            return _iCustomersDB.GetAllCategories();
        }
        public Task<List<CustomersModel>> GetAllCustomer()
        {
            return _iCustomersDB.GetAllCustomer();

        }
        public Task<List<EmployeesModel>> GetAllEmployees()
        {
            return _iCustomersDB.GetAllEmployees();

        }
        public Task<List<OrderDetailsModel>> GetAllOrderDetails()
        {
            return _iCustomersDB.GetAllOrderDetails();

        }
        public Task<List<OrdersModel>> GetAllOrders()
        {
            return _iCustomersDB.GetAllOrders();

        }

        public Task<List<ProductsModel>> GetAllProducts()
        {
            return _iCustomersDB.GetAllProducts();

        }
        public Task<List<ShippersModel>> GetAllShippers()
        {
            return _iCustomersDB.GetAllShippers();

        }
        public Task<List<SuppliersModel>> GetAllSuppliers()
        {
            return _iCustomersDB.GetAllSuppliers();

        }
    }
}




