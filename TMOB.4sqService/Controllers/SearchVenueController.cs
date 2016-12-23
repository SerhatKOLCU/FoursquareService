using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TMOB._4sqService.DTOs;
using TMOB._4sqService.Models;

namespace TMOB._4sqService.Controllers
{
    public class SearchVenueController : ApiController
    {
        private TMOB_4sqServiceContext db = new TMOB_4sqServiceContext();

        // Init Service: api/Init
        /// <summary>
        /// Search venues by keyword and location informations or city name.
        /// </summary>
        /// <param name="init"></param>
        /// <returns></returns>
        [ResponseType(typeof(VenueDTO))]
        public IEnumerable<VenueDTO> Search(ReqSearch keyword)
        {
            #region
            if (keyword.searchKeyword == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Error: searchKeyword can not be null!") });
            }
            if (keyword.City != null && keyword.Location != null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Error: Location and City parameters can not pass at the same query!") });
            }
            else if (keyword.City == null && keyword.Location == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Error: Location and City parameters can not be null at the same query!") });
            }
            #endregion
            else
            {
                if (VenueDTO.Mode == Modes.Test)
                {
                    var venues = from v in db.Venues.Where(x => x.Tags.Contains(keyword.searchKeyword)).Take(5)
                                 select new VenueDTO()
                                 {
                                     ID = v.ID,
                                     Name = "T-" + v.Name,
                                     Country = v.Country,
                                     City = v.City,
                                     Location = v.Location,
                                     PeopleHereNow = v.PeopleHereNow,
                                     URL = v.URL ?? "http://www.google.com",
                                     Likes = v.Likes,
                                     Like = v.Like,
                                     Dislike = v.Dislike
                                 };
                    return venues;
                }
                else
                {
                    var venues = from v in db.Venues.Where(x => x.Tags.Contains(keyword.searchKeyword)).Take(5)
                                 select new VenueDTO()
                                 {
                                     ID = v.ID,
                                     Name = v.Name,
                                     Country = v.Country,
                                     City = v.City,
                                     Location = v.Location,
                                     PeopleHereNow = v.PeopleHereNow,
                                     URL = v.URL ?? "http://www.google.com",
                                     Likes = v.Likes,
                                     Like = v.Like,
                                     Dislike = v.Dislike
                                 };
                    return venues;
                }

            }
        }
    }
}