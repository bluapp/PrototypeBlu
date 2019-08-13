using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazor.Pages.Tarifas
{
    public class TarifasModel : PageModel
    {
        public Models.Ticket tickets;
        public List<Models.Ticket> tarifas = new List<Models.Ticket>();

        [BindProperty]
        public string busca { get; set; }

        public void OnGet()
        {
            DataTable ticketsDT = Call.Calls.GetTickets().GetAwaiter().GetResult();

            foreach (DataRow row in ticketsDT.Rows)
            {
                tickets = new Models.Ticket();

                tickets.ID = Guid.Parse(row.ItemArray[0].ToString());
                tickets.Price = decimal.Parse(row.ItemArray[1].ToString());

                tarifas.Add(tickets);
            }
        }
    }
}