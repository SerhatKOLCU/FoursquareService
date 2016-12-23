using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TMOB._4sqService.Models;

namespace TMOB._4sqService.Controllers
{
    public class VenuesController : ApiController
    {
        private TMOB_4sqServiceContext db = new TMOB_4sqServiceContext();

        // GET: api/Venues
        public IQueryable<Venue> GetVenues()
        {
            return db.Venues;
        }

        // GET: api/Venues/5
        [ResponseType(typeof(Venue))]
        public IHttpActionResult GetVenue(int id)
        {
            Venue venue = db.Venues.Find(id);
            if (venue == null)
            {
                return NotFound();
            }

            return Ok(venue);
        }

        // PUT: api/Venues/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVenue(int id, Venue venue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != venue.ID)
            {
                return BadRequest();
            }

            db.Entry(venue).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VenueExists(id))
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

        // POST: api/Venues
        [ResponseType(typeof(Venue))]
        public IHttpActionResult PostVenue(Venue venue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Venues.Add(venue);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = venue.ID }, venue);
        }

        // DELETE: api/Venues/5
        [ResponseType(typeof(Venue))]
        public IHttpActionResult DeleteVenue(int id)
        {
            Venue venue = db.Venues.Find(id);
            if (venue == null)
            {
                return NotFound();
            }

            db.Venues.Remove(venue);
            db.SaveChanges();

            return Ok(venue);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VenueExists(int id)
        {
            return db.Venues.Count(e => e.ID == id) > 0;
        }
    }
}