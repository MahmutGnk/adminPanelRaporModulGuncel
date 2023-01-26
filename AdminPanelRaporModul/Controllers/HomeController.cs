using AdminPanelRaporModul.Data.Abstract;
using AdminPanelRaporModul.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanelRaporModul.Controllers
{

    public class HomeController : Controller
    {
        IOrderProductListDal _orderProductListDal;

        public IActionResult Index()
        {
            return View(_orderProductListDal.GetAll());
        }
        public HomeController(IOrderProductListDal orderProductListDal)
        {
            _orderProductListDal = orderProductListDal;
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        public List<ProductOrder> GetAll()
        {
            return _orderProductListDal.GetAll();
        }



        public IActionResult Privacy()
        {
            return View();
        }
       public IActionResult GetgraphData()
        {
            var data = new List<ProductOrder>();
            return View();
        }
    }
}
