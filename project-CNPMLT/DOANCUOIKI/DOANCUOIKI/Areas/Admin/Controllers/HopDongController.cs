using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOANCUOIKI.DB;

namespace DOANCUOIKI.Areas.Admin.Controllers
{
    public class HopDongController : Controller
    {
        DBQLPhongTroEntities db = new DBQLPhongTroEntities();
        // GET: Admin/HopDong
        public ActionResult HopDong()
        {
            List<HOPDONG> hd = db.HOPDONGs.ToList();
            return View(hd);
        }
    }
}