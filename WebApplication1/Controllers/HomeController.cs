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

        IDataRepository dataRepository;

        public HomeController()
        {
            var ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TarifsContext;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TarifsContext.mdf";
            //this.dataRepository = new DBRepository(ConnectionString);
            this.dataRepository = new ListRepository();
        }
        public ActionResult Index()
        {
            return View(this.dataRepository.getTarifsFlat());
        }
        public ActionResult Internet()
        {
            return View(this.dataRepository.getTarifs());
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
                this.dataRepository.createRequest(request);
                return View();
            }
            catch (Exception ex)
            {
                return Index();

            }
        }
    }
}