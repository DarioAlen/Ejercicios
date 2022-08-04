using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoWEB.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        private HotelWEB.Negocio.HotelNegocio negocio;

        public HotelController()
        {
            negocio = new HotelWEB.Negocio.HotelNegocio();
        }
        public ActionResult Index()
        {
            var lst = negocio.RetornarHoteles();
            return View(lst);
        }

        // GET: Hotel/Details/5

        public ActionResult Alta()
        {
            var codCivil = new List<string>();
            codCivil.Add("seleccione");
            codCivil.Add("Soltero");
            codCivil.Add("Casado");

            ViewBag.lstCodCivil = codCivil;

            return View();
        }

        public ActionResult Alta(string nombre, string codCivil)
        {
            var hotel = new HotelWEB.Clases.HotelEntidad(0, nombre, codCivil, 0, false);

            if (false)
            {
                return RedirectToAction("Index");
            }

            else
            {
                return View(hotel);
            }
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hotel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotel/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hotel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
