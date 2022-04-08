using onlinemarketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlinemarketing.Controllers
{
    public class HomeController : Controller
    {
        //private object obj;

        onlinemarketingEntities obj;

        public HomeController()
        {
            obj = new onlinemarketingEntities();
        }



        //public ActionResult Index()
        //{​​​​​​​​
        //    IEnumerable<Shopping> listOfShopping = (from objItem in obj.products
        //                                            select new Shopping()
        //                                            {​​​​​​​​
        //                                                pro_image = objItem.pro_image,
        //                                                pro_name = objItem.pro_name,
        //                                                pro_description = objItem.pro_description,
        //                                                pro_price = objItem.pro_price,
        //                                                pro_id = objItem.pro_id,

        //                                            }).ToList();​
        //    return View(listOfShopping);
        //}​​​​​​​​

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