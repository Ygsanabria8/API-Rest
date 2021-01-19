using API2.Models;
using API2.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API2.TicketData
{
    public class ImplTicketData : ITicketData
    {
        private TicketContext _context;

        public ImplTicketData(TicketContext context)
        {
            _context = context;
        }


        public List<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();

        }
        public TicketDTO GetTicket(int idTicket)
        {
            TicketMapper ticketMapper = new TicketMapper();
            Ticket ticket = _context.Tickets.Find(idTicket);
            TicketDTO ticketDTO = ticketMapper.TicketoToTicketDTO(ticket);
            return ticketDTO;
        }

        public TicketDTO AddTicket(TicketDTO ticketDTO)
        {
            TicketMapper ticketMapper = new TicketMapper();
            Ticket ticket = ticketMapper.TicketDTOToTicket(ticketDTO);
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
            ticketDTO = ticketMapper.TicketoToTicketDTO(ticket);
            return ticketDTO;
            
        }
        public TicketDTO EditTicket(TicketDTO ticketDTO)
        {
            TicketMapper ticketMapper = new TicketMapper();
            Ticket ticket = ticketMapper.TicketDTOToTicket(ticketDTO);
            _context.Entry(ticket).State = EntityState.Modified;
            _context.SaveChanges();
            ticketDTO = ticketMapper.TicketoToTicketDTO(ticket);
            return ticketDTO;
        }

        public void DeleteTicket(int idTicket)
        {
            Ticket ticket = _context.Tickets.Find(idTicket);
            _context.Tickets.Remove(ticket);
            _context.SaveChanges();
            
        }

        

        

        
    }
}
