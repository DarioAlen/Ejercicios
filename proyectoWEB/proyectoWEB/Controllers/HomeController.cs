using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelWEB.Negocio;
using HotelWEB.Clases;


namespace proyectoWEB.Controllers
{
    public class HomeController : Controller
    {
        private HotelNegocio hn;
        private List<Cliente> lst;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            hn = new HotelNegocio();
            lst = hn.RetornarClientes();

            return View(lst);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Mision()
        {
            return View();
        }
    }
}