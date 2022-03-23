using AgendaMVC.Models;
using AgendaMVC.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaMVC.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult Index()
        {       
            return View();
        }
        [HttpPost]
        public ActionResult Add(HelpersModel model)
        {
            using (GitAgendaEntities db = new GitAgendaEntities())
            {
                var Ouser = new tContacto();
                Ouser.nombre = model.nombre;
                Ouser.apellido = model.apellido;
                db.tContacto.Add(Ouser);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Home/Index"));
        }
    }
}