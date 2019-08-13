using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Ticket
    {
        public Guid ID { get; set; }
        public decimal Price { get; set; }
        public string Register_Date { get; set; }
        public string Alter_Date { get; set; }
    }
}
