using MVCNHibernate.Models;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNHibernate.Controllers
{
    public class EmpresaController:Controller
    {
        public ActionResult Index()
        {
            using (ISession session = OpenEmpresaHibernateSession.OpenSession())
            {
                var empresa = session.Query<Empresa>().ToList();
                return View(empresa);
            }
        }
    }
}