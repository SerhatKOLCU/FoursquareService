using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TMOB._4sqService.Models;

namespace TMOB._4sqService.Controllers
{
    public class InitController : ApiController
    {
        private TMOB_4sqServiceContext db = new TMOB_4sqServiceContext();

        // Init Service: api/Init
        /// <summary>
        /// Check application needs to update (if application version is higher than 1.1.3 then returns false, else returns true).
        /// </summary>
        /// <param name="init"></param>
        /// <returns></returns>
        [ResponseType(typeof(Transaction))]
        public async Task<IHttpActionResult> Initialize(Init init)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Init.needsUpdate = checkVersion(init.transactionInfo.ApplicationVersion);
            return Ok(Init.needsUpdate);
            //return Ok(init.needsUpdate);
        }

        bool checkVersion(string version)
        {
            int[] cmp = new int[3];

            if (version.Contains("."))
            {
                string[] ver = version.Split('.');

                cmp = Array.ConvertAll(ver, int.Parse);
            }
            else
            {
                cmp[0] = Convert.ToInt32(version);

            }
            if (cmp[0] > 1)
            {
                return false;
            }
            else if (cmp[0] <= 1 && cmp[1] > 1)
            {
                return false;
            }
            else if (cmp[0] <= 1 && cmp[1] == 1 && cmp[2] >= 3)
            {
                return false;
            }
            else { return true; }
        }


        void checkMode(Modes mode)
        {
            if (mode == Modes.Test)
            {
                Venue venue = new Venue();
                venue.Name = "T" + venue.Name;
            }
        }
    }
}
