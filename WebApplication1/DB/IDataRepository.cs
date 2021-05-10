using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public interface IDataRepository
    {

        IEnumerable<Models.Tarif> getTarifs();
        IEnumerable<Models.Tarif> getTarifsFlat();
        void  createRequest(Models.Request request);
    }
}