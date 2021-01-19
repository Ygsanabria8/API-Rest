using API2.Models;
using API2.Models.DTO;
using API2.TicketData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private ITicketData _ticketData;

        public TicketsController(ITicketData ticketData)
        {
            _ticketData = ticketData;
        }

        // GET: api/<TicketsController>
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return _ticketData.GetTickets();
        }

        // GET api/<TicketsController>/5
        [HttpGet("{idTicket}")]
        public TicketDTO Get(int idTicket)
        {
            return _ticketData.GetTicket(idTicket);
        }

        // POST api/<TicketsController>
        [HttpPost]
        public ActionResult Post([FromBody] TicketDTO ticketDTO)
        {
            ticketDTO = _ticketData.AddTicket(ticketDTO);
            return Ok(ticketDTO);
        }

        // PUT api/<TicketsController>/5
        [HttpPut("{idTicket}")]
        public ActionResult Put(int idTicket, [FromBody] TicketDTO ticketDTO)
        {
            if (ticketDTO.idTicket == idTicket)
            {
                ticketDTO = _ticketData.EditTicket(ticketDTO);
                return Ok(ticketDTO);
            }
            else
            {
                return BadRequest("Ticket was not found");
            }
        }

        // DELETE api/<TicketsController>/5
        [HttpDelete("{idTicket}")]
        public ActionResult Delete(int idTicket)
        {
            _ticketData.DeleteTicket(idTicket);
            return Ok();
        }
    }
}
