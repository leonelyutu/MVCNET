using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace WEB04inventario.Controllers
{
    public class HomeController : Controller
    {
        private Producto productos = new Producto();

        public ActionResult Index()
        {
            return View(productos.Listar());
        }
    }
}