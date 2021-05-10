using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;



using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication1.DB;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RequestController : ControllerBase
    {
        private readonly dbRep db;

        public RequestController()
        {
            var ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TarifsContext;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\TarifsContext.mdf";
            this.db = new dbRep(ConnectionString);
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromForm]RequestController request)
        {
        }

        [Microsoft.AspNetCore.Mvc.Route("api/[controller]/tutor/create_request")]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult CreateRequest([FromForm] Request request )
        {

        
            try
            {

                db.CreateRequest(new Models.Request()
                {
                    FIO = request.FIO,
                    Phone = request.Phone,
                    Email = request.Email,

                });
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
             
            }

          
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}