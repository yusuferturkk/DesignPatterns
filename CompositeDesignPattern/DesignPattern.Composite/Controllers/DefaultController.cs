using DesignPattern.Composite.CompositePattern;
using DesignPattern.Composite.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x => x.Products).ToList();
            var values = Rekursive(categories, new Category { CategoryName = "FirstCategory", CategoryId = 0 }, new ProductComposite("FirstComposite", 0));
            ViewBag.v = values;
            return View();
        }

        public ProductComposite Rekursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.CategoryId).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryName, y.CategoryId);
                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductName, z.ProductId));
                });
                
                if(leaf != null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
