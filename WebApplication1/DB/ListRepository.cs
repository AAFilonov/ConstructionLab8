using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DB
{
    public class ListRepository : IDataRepository
    {
        List<Tarif> tarifs;
        List<Request> requests; 
        public ListRepository()
        {
            tarifs = new List<Tarif>() ;
            requests = new List<Request>();
            tarifs.Add(new Tarif
            {
                Id = 0,
                Title = "Тариф 11",
                Descr = "Длинное описание 11",               
                Price = 550,               
                TypeID = 1
            }) ;
            tarifs.Add(new Tarif
            {
                Id = 1,
                Title = "Тариф 21",
                Descr = "Длинное описание 21",
                Price = 950,
                TypeID = 1
            });
            tarifs.Add(new Tarif
            {
                Id = 1,
                Title = "Тариф 31",
                Descr = "Длинное описание 31",
                Price = 1950,
                TypeID = 1
            });
            tarifs.Add(new Tarif
            {
                Id = 0,
                Title = "Тариф 12",
                Descr = "Длинное описание 12",
                Price = 550,
                TypeID = 2
            });
            tarifs.Add(new Tarif
            {
                Id = 1,
                Title = "Тариф 22",
                Descr = "Длинное описание 22",
                Price = 950,
                TypeID = 2
            });
            tarifs.Add(new Tarif
            {
                Id = 1,
                Title = "Тариф 32",
                Descr = "Длинное описание 32",
                Price = 1950,
                TypeID = 2
            });
        }

        public void createRequest(Request request)
        {
            requests.Add (new Models.Request()
            {
                FIO = request.FIO,
                Phone = request.Phone,
                Email = request.Email,

            });
        }

        public IEnumerable<Tarif> getTarifs()
        {
            return tarifs;
        }

        public IEnumerable<Tarif> getTarifsFlat()
        {
            return tarifs.Where((a) => a.TypeID == 2);
        }
    }
}