using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using facebookfinal.Models;

namespace facebookfinal.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("Index");
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(ModalClass mc,string cmd)
        {
            string msg = mc.login();
            return Content("<script language='JavaScript' type='text/JavaScript'>alert('"+msg+"')</script>");
        }
        
        
      
            

    }
}
