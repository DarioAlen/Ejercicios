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
        private HotelNegocio hn = new HotelNegocio();
        private List<Cliente> lst;
        private List<Cliente> lstDesplegables;
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

        public ActionResult DesplegableDePrueba()
        {
            lstDesplegables = hn.RetornarClientes();
            return View(lstDesplegables);
        }

        public ActionResult EdicionCliente()
        {
            Cliente cli = new Cliente(Convert.ToInt32(Request.Form["id"]),
                                      Convert.ToDateTime("7/7/ 2022 00:00:00"),
                                      false,
                                      Request.Form["nombre"],
                                      Request.Form["apellido"],
                                      Request.Form["direccion"],
                                      Request.Form["telefono"],
                                      Request.Form["mail"],
                                      Convert.ToDateTime("7/7/ 2022 00:00:00")
                                      );
            return View(cli);
        }

        public ActionResult PlantillaAlta()
        {
            return View();
        }
    }
}