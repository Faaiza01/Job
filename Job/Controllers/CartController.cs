using Job.Data.Models.Domain;
using Job.Services.IService;
using Job.Services.Models;
using Job.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job.Controllers
{
    public class CartController : Controller
    {
        IList<CartMusic> cart;
        IOrderService orderService;
        IMusicService musicService;
        IUserService userService;

        public CartController()
        {
            orderService = new OrderService();
            musicService = new MusicService();
            userService = new UserService();
        }

        //public ActionResult AddToCart(int id)
        //{
        //    if (Session["cart"] != null) //There is a cart in the session
        //    {
        //        cart = (List<CartMusic>)Session["cart"];
        //        if (GetCartItemIdList(cart).Contains(id)) //If there is item already in the cart increment the quanity
        //        {
        //            return RedirectToAction("ReviseItem", new { id = id, toDo = "increment" });
        //        }
        //        else //If there is no item already in the cart add the item to current cart
        //        {
        //            CartMusic item = new CartMusic();
        //            item.Music = musicService.GetMusic(id);
        //            item.Quantity = 1;
        //            cart.Add(item); //add item to the cart
        //            Session["cart"] = cart; //Update cart in the session
        //            return RedirectToAction("DisplayCart"); //Redirect to Display
        //        }
        //    }

        //    else //If no cart in the session, Create it
        //    {
        //        cart = new List<CartMusic>();

        //        //Prepare the cart
        //        CartMusic item = new CartMusic();
        //        item.Music = musicService.GetMusic(id);
        //        item.Quantity = 1;
        //        cart.Add(item); //add item to the cart
        //        Session["cart"] = cart; //Update cart in the session
        //        return RedirectToAction("DisplayCart"); //Redirect to Display
        //    }           
        //}


        //public ActionResult DisplayCart()
        //{
        //    if (Session["cart"] != null)
        //    {
        //        return View((List<CartMusic>)Session["cart"]);
        //    }
        //    else
        //    {
        //        return RedirectToAction("GetGenres", "Genre");
        //    }
        //}

        //int[] GetCartItemIdList(IList<CartMusic> cart)
        //{
        //    int[] IDs = new int[cart.Count];

        //    for (int i = 0; i < cart.Count; i++)
        //    {
        //        IDs[i] = cart[i].Music.ID;
        //    }
        //    return IDs;
        //}

        //public ActionResult ReviseItem(int id, string toDo)
        //{
        //    var cart = (List<CartMusic>)Session["cart"];
        //    CartMusic item = cart.Find(o => o.Music.ID == id);
        //    cart.Remove(item); //Remove from the cart

        //    if (toDo == "remove")
        //    {
        //        Session["cart"] = cart; //Put cart in the session
        //        return RedirectToAction("DisplayCart");
        //    }
        //    if (toDo == "increment")
        //    {
        //        item.Quantity = item.Quantity + 1;
        //    }
        //    else if (toDo == "decrement")
        //    {
        //        if (item.Quantity == 1)
        //        {
        //            Session["cart"] = cart; //Put cart in the session
        //            return RedirectToAction("DisplayCart");
        //        }
        //        item.Quantity = item.Quantity - 1;
        //    }
        //    cart.Add(item); //Add updated item to cart
        //    Session["cart"] = cart; //Update the cart Session
        //    return RedirectToAction("DisplayCart");
        //}

        //[Authorize]
        //public ActionResult CheckOut()
        //{
        //    string userId = (string)Session["UserId"];
        //    User user = userService.GetUser(userId);
        //    List<CartMusic> cart = (List<CartMusic>)Session["cart"];
        //    CheckOutUser checkOutUser = new CheckOutUser() { User = user, Cart = cart };
        //    TempData["checkOutUser"] = checkOutUser;
        //    return View(checkOutUser);
        //}

        //[HttpPost]
        //public ActionResult CheckOut(CheckOutUser _checkOutForAddress)
        //{
        //    CheckOutUser checkOutUser = (CheckOutUser)TempData["checkOutUser"];
        //    checkOutUser.DelAddress = _checkOutForAddress.DelAddress;
        //    orderService.AddOrder(checkOutUser);
        //    return RedirectToAction("GetGenres", "Genre");
        //}

        public ActionResult Index()
        {
            return View();
        }
    }
}