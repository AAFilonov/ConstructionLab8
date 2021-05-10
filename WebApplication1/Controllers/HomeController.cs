using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly dbRep db;

        public HomeController()
        {
            var ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TarifsContext;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TarifsContext.mdf";
            this.db = new dbRep(ConnectionString);
        }
        public ActionResult Index()
        {

        
            var flatsTarifs = db.GetTarifsFlat();
            return View(flatsTarifs);
        }
        public ActionResult Internet()
        {
            var data = db.GetTarifs();
 
       
            return View(data);
        }
        public ActionResult LK()
        {
            return View();
        }
        public ActionResult Request_()
        {
            return View();
        }
   

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public ActionResult CreateRequest([Microsoft.AspNetCore.Mvc.FromForm] Request request)
        {
            try
            {

                db.CreateRequest(new Models.Request()
                {
                    FIO = request.FIO,
                    Phone = request.Phone,
                    Email = request.Email,

                });
                return View();
            }
            catch (Exception ex)
            {
                return Index();

            }
        }
    }
}