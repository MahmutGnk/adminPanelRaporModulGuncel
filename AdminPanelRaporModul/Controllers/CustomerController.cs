using AdminPanelRaporModul.Data.Abstract;
using AdminPanelRaporModul.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanelRaporModul.Controllers
{
    public class CustomerController : Controller
    {
        IOrderProductListDal _orderProductListDal;

        public CustomerController(IOrderProductListDal orderProductListDal)
        {
            _orderProductListDal = orderProductListDal;
        }

        public IActionResult Index()
        {
            return View(_orderProductListDal.GetAll());
        }
        
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public List<ProductOrder> GetAll() {
            return _orderProductListDal.GetAll();   
        }
    }
}
