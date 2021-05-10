using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DB
{

    public class dbRep : ConnectionBase
    {
        public dbRep(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Tarif> GetTarifs()
        {
            return Connection.Query<Tarif>(
                "select * from Tarifs"          
            );
        }
        public IEnumerable<Tarif> GetTarifsHouse()
        {
            return Connection.Query<Tarif>(
                "select * from Tarifs where TypeID ='2'"
            );
        }
        public IEnumerable<Tarif> GetTarifsFlat()
        {
            return Connection.Query<Tarif>(
               "select * from Tarifs where TypeID ='1'"
            );
        }

        public void CreateRequest(Request @request)
        {
            Connection.Query(
                "Insert into Requests (Requests.FIO,Requests.Email,Requests.Phone )  VALUES(@FIO, @Email, @Phone )",
            new {
                FIO = request.FIO,
                Email = request.Email,
                Phone = request.Phone
            });

        }
        

    }

   
   
   
}


 