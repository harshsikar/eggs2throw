using eggs2throw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eggs2throw.Controllers
{
    public class ListController : ApiController
    {
        private eggs2throwEntities db = new eggs2throwEntities();
        public IEnumerable<movieProfile> Get()
        {
            return db.movieProfiles.ToList();
        }

    }
}
