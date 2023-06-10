using DesignPattern.TemplateMethod.TemplateDesignPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65);
            ViewBag.v4 = netflixPlans.Resolution("720p");
            ViewBag.v5 = netflixPlans.Content("Film-Dizi");

            return View();
        }

        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(95);
            ViewBag.v4 = netflixPlans.Resolution("1080p");
            ViewBag.v5 = netflixPlans.Content("Film-Dizi-Animasyon");

            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(120);
            ViewBag.v4 = netflixPlans.Resolution("1080p - 4K");
            ViewBag.v5 = netflixPlans.Content("Film-Dizi-Animasyon- Belgesel");

            return View();
        }
    }
}
