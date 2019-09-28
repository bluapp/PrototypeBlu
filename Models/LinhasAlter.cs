using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LinhasAlter
    {
        public Guid ID { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public Ticket Ticket { get; set; }
        public string Register_Date { get; set; }
        public string Alter_Date { get; set; }
        public Guid Alter_ID { get; set; }
        public string Status { get; set; }
        public Guid UserID { get; set; }
    }
}
