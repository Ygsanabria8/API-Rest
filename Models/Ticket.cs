using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Models
{
    public class Ticket
    {
        [Key]
        public int idTicket { get; set; }
        public string username { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
        public Boolean status { get; set; }
    }
}
