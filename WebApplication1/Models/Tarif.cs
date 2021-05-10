using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Tarif
    {
       
        public int Id { get; set; }
        public int TypeID { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
   
        

    }
}