using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DB
{
    public class DBRepository : IDataRepository
    {
        private readonly dbRep db;
        public DBRepository(string connectionString)
        {
            db = new dbRep(connectionString);
        }

        public void createRequest(Request request)
        {

            db.CreateRequest(new Models.Request()
            {
                FIO = request.FIO,
                Phone = request.Phone,
                Email = request.Email,

            });
        }

        public IEnumerable<Tarif> getTarifs()
        {
          return db.GetTarifs();
        }

        public IEnumerable<Tarif> getTarifsFlat()
        {
            return db.GetTarifsFlat();
        }
    }
}