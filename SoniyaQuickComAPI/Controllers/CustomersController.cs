using Entity.DBLayer;
using Entity.DBLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickCom.BussinessLayer;

namespace SoniyaQuickComAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersBusiness _customersBusiness;

        public CustomersController(ICustomersBusiness customersBusiness)
        {
            _customersBusiness=customersBusiness;
        }
        [HttpGet("GetAllCategories")]
        
        public async Task<List<CategoriesModel>>GetAllCategories()
        {
            return await _customersBusiness.GetAllCategories();
                
        }
        [HttpGet("GetAllCustomer")]

        public async Task<List<CustomersModel>> GetAllCustomer()
        {
            return await _customersBusiness.GetAllCustomer();

        }
        [HttpGet("GetAllEmployees")]

        public async Task<List<EmployeesModel>> GetAllEmployees()
        {
            return await _customersBusiness.GetAllEmployees();

        }
        [HttpGet("GetAllOrderDetails")]

        public async Task<List<OrderDetailsModel>> GetAllOrderDetails()
        {
            return await _customersBusiness.GetAllOrderDetails();

        }
        [HttpGet("GetAllOrders")]
        public async Task<List<OrdersModel>> GetAllOrders()
        {
            return await _customersBusiness.GetAllOrders();

        }
        [HttpGet("GetAllProducts")]
        public async Task<List<ProductsModel>> GetAllProducts()
        {
            return await _customersBusiness.GetAllProducts();

        }
        [HttpGet("GetAllShippers")]
        public async Task<List<ShippersModel>> GetAllShippers()
        {
            return await _customersBusiness.GetAllShippers();

        }
        [HttpGet("GetAllSuppliers")]
        public async Task<List<SuppliersModel>> GetAllSuppliers()
        {
            return await _customersBusiness.GetAllSuppliers();

        }

    }
}
