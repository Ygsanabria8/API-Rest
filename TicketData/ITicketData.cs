using API2.Models;
using API2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.TicketData
{
    public interface ITicketData
    {
        List<Ticket> GetTickets();
        TicketDTO GetTicket(int idTicket);
        TicketDTO AddTicket(TicketDTO ticketDTO);
        void DeleteTicket(int idTicket);
        TicketDTO EditTicket(TicketDTO ticketDTO);
    }
}
