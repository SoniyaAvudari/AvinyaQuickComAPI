using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DBLayer.Model;

namespace QuickCom.BussinessLayer
{
    public interface ICustomersBusiness
    {
        public Task<List<CategoriesModel>> GetAllCategories();
        public Task<List<CustomersModel>> GetAllCustomer();
        public Task<List<EmployeesModel>> GetAllEmployees();
        public Task<List<OrderDetailsModel>> GetAllOrderDetails();
        public Task<List<OrdersModel>>GetAllOrders();
        public Task<List<ProductsModel>> GetAllProducts();
        public Task<List<ShippersModel>> GetAllShippers();
        public Task<List<SuppliersModel>> GetAllSuppliers();
    }
}
