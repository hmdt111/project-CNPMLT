using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOANCUOIKI.DB;

namespace DOANCUOIKI.Areas.Admin.Controllers
{
    public class PhongTroController : Controller
    {
        DBQLPhongTroEntities db = new DBQLPhongTroEntities();
        // GET: Admin/PhongTro
        public ActionResult PhongTro()
        {
            List<PHONGTRO> pt = db.PHONGTROes.ToList();
            return View(pt);
        }
    }
}