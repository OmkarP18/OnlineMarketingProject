using onlinemarketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlinemarketing.Controllers
{
    public class CartController : Controller
    {

       // onlinemarketingEntities obj = new onlinemarketingEntities();
        private onlinemarketingEntities obj;
        private List<Cart> shoppinglist;

        public CartController()
        {
            obj = new onlinemarketingEntities();
        }

        public ActionResult Add(int ProductId)
        {



            Cart cart = new Cart();
            product pro = obj.products.Single(x => x.pro_id == ProductId);
            if (Session["count"] != null)
            {
                shoppinglist = (List<Cart>)Session["cart"];
            }

            if (shoppinglist.Any(model => model.pro_id == ProductId))
            {
                cart = shoppinglist.Single(model => model.pro_id == ProductId);
                cart.Quantity = cart.Quantity + 1;
                cart.Total = cart.pro_price * cart.Quantity;
            }


            else
            {
                cart.pro_id = ProductId;
                cart.pro_image = pro.pro_image;
                cart.pro_name = pro.pro_name;
                cart.Quantity = 1;
                cart.Total = pro.pro_price;
                cart.pro_price = pro.pro_price;
                shoppinglist.Add(cart);
            }

            Session["cart"] = shoppinglist;
            Session["count"] = shoppinglist.Count;

            return RedirectToAction("Index", "User");
        }


        public ActionResult Myorder()
        {
            return View((List<Cart>)Session["cart"]);
        }

        public ActionResult Remove(Cart s)
        {
            shoppinglist = (List<Cart>)Session["cart"];
            shoppinglist.RemoveAll(x => x.pro_id == s.pro_id);
            Session["cart"] = shoppinglist;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;

            return RedirectToAction("Myorder", "Cart");
        }


       
    }
}