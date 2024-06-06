using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOANCUOIKI.DB;

namespace DOANCUOIKI.Areas.Admin.Controllers
{
    public class DichVuController : Controller
    {
        DBQLPhongTroEntities db = new DBQLPhongTroEntities();
        // GET: Admin/DichVu
        public ActionResult DichVuHome()
        {

            List<DICHVU> dv = db.DICHVUs.ToList();
            return View(dv);
        }
    }
}