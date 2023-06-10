using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            List<SelectListItem> customers = (from x in context.Customers.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CustomerName + " " + x.CustomerSurname,
                                                  Value = x.CustomerID.ToString()
                                              }).ToList();
            ViewBag.customer = customers;

            List<SelectListItem> products = (from x in context.Products.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.ProductName,
                                                 Value = x.ProductID.ToString()
                                             }).ToList();
            ViewBag.product = products;

            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerID, int productID, int orderID, int productCount, decimal productPrice)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrderDetail(customerID, productID, orderID, productCount, productPrice);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = context.OrderDetails.ToList();
            return View(values);
        }
    }
}
