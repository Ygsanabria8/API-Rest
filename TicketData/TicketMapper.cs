using API2.Models;
using API2.Models.DTO;

namespace API2.TicketData
{
    public class TicketMapper
    {
        public Ticket TicketDTOToTicket(TicketDTO ticketDTO)
        {
            Ticket ticket = new Ticket();
            ticket.idTicket = ticketDTO.idTicket;
            ticket.username = ticketDTO.username;
            ticket.createdDate = ticketDTO.createdDate;
            ticket.updateDate = ticketDTO.updateDate;
            ticket.status = ticketDTO.status;

            return ticket;
        }

        public TicketDTO TicketoToTicketDTO(Ticket ticket)
        {
            TicketDTO ticketDTO = new TicketDTO();
            ticketDTO.idTicket = ticket.idTicket;
            ticketDTO.username = ticket.username;
            ticketDTO.createdDate = ticket.createdDate;
            ticketDTO.updateDate = ticket.updateDate;
            ticketDTO.status = ticket.status;
            return ticketDTO;
        }
    }
}
