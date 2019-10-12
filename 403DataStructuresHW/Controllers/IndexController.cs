using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403DataStructuresHW.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            Stack<string> ssStack = new Stack<string>();
            Queue<string> qsQueue = new Queue<string>();
            Dictionary<int, string> dsDictionary = new Dictionary<int, string>();

            SidebarMenu(ssStack);


            return View();
        }

        public void SidebarMenu (object objectType)
        {
            string sObjectType = objectType.GetType().Name;
            sObjectType = sObjectType.Substring(0, sObjectType.IndexOf("`"));



            int iMenuNumber = 0;


            ViewBag.SideMenu = "<div class=\"w3-sidebar w3-light-grey w3-bar-block\" style=\"width:25%\">";
            ViewBag.SideMenu += "<h3 class=\"w3-bar-item\">" + sObjectType + " Menu</h3>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Add one time to " + sObjectType + "</a>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Add Huge List of Items to " + sObjectType + "</a>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Display " + sObjectType + "</a>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Delete from " + sObjectType + "</a>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Clear " + sObjectType + "</a>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Search " + sObjectType + "</a>";
                ViewBag.SideMenu += "<a href = \"#\" class=\"w3-bar-item w3-button\">" + ++iMenuNumber + ". Return to Main Menu</a>";
            ViewBag.SideMenu += "</div>";
        }

        /*
1. Add one time to Stack
2. Add Huge List of Items to Stack
3. Display Stack
4. Delete from Stack
5. Clear Stack
6. Search Stack
7. Return to Main Menu
         */

    }


}