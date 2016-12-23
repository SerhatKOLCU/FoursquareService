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
    public class SearchVenueController : ApiController
    {
        private TMOB_4sqServiceContext db = new TMOB_4sqServiceContext();

        // GET: api/SearchVenue
        public IQueryable<SearchVenue> GetSearchVenues()
        {
            return db.SearchVenues;
        }

        // GET: api/SearchVenue/5
        [ResponseType(typeof(SearchVenue))]
        public async Task<IHttpActionResult> GetSearchVenue(SearchVenue sv)
        {
            SearchVenue searchVenue = db.SearchVenues.Find(sv.searchKeyword);
            //Venue venue = db.Venues.Find(venue.ID);
            if (searchVenue == null)
            {
                return NotFound();
            }

            return Ok(searchVenue);
        }

        // PUT: api/SearchVenue/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSearchVenue(string id, SearchVenue searchVenue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != searchVenue.searchKeyword)
            {
                return BadRequest();
            }

            db.Entry(searchVenue).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SearchVenueExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SearchVenue
        [ResponseType(typeof(SearchVenue))]
        public IHttpActionResult PostSearchVenue(SearchVenue searchVenue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SearchVenues.Add(searchVenue);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SearchVenueExists(searchVenue.searchKeyword))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = searchVenue.searchKeyword }, searchVenue);
        }

        // DELETE: api/SearchVenue/5
        [ResponseType(typeof(SearchVenue))]
        public IHttpActionResult DeleteSearchVenue(string id)
        {
            SearchVenue searchVenue = db.SearchVenues.Find(id);
            if (searchVenue == null)
            {
                return NotFound();
            }

            db.SearchVenues.Remove(searchVenue);
            db.SaveChanges();

            return Ok(searchVenue);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SearchVenueExists(string id)
        {
            return db.SearchVenues.Count(e => e.searchKeyword == id) > 0;
        }
    }
}