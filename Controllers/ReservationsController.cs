using ExpressoWebApi.Data;
using ExpressoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpressoWebApi.Controllers
{
    public class ReservationsController : ApiController
    {
        ExpressoDbContext expressoDbContex = new ExpressoDbContext();

        public IHttpActionResult Post(Reservation reservation)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            expressoDbContex.Reservations.Add(reservation);
            expressoDbContex.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
