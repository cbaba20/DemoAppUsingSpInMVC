using DAL.Models;
using DemoBL.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace DemoWeb.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()

        {
            Northwind_DatabaseEntities db = new Northwind_DatabaseEntities();
            var models = db.usp_CustOrdersDetails(null);
            var viewModel = new usp_CustOrdersDetails_ResultViewModel { orderDetailsVM = models.ToList() };

            return View(viewModel);
        }
        //post method
        [HttpPost]
        public ActionResult Index(usp_CustOrdersDetails_ResultViewModel order)
        {
            Northwind_DatabaseEntities db = new Northwind_DatabaseEntities();
            var models = db.usp_CustOrdersDetails(order.ProductName);
            var viewModel = new usp_CustOrdersDetails_ResultViewModel { orderDetailsVM = models.ToList() };

            return View(viewModel);
        }
    }
}