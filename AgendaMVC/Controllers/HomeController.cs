using AgendaMVC.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendaMVC.Models;


namespace AgendaMVC.Controllers
{
    public class HomeController : Controller
    {      
        public ActionResult Index()
        {
            List<Registers> lst = new List<Registers>();
            using (GitAgendaEntities db = new GitAgendaEntities())
            {
                lst = (from d in db.tContacto
                       orderby d.id
                       select new Registers
                       {
                           Id = d.id,
                           Nombre = d.nombre,
                           Apellido = d.apellido
                       }).ToList();
            }
            return View(lst);        
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}