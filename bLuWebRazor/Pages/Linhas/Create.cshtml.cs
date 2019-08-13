using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazor.Pages.Linhas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string number { get; set; }
        [BindProperty]
        public string description { get; set; }
        [BindProperty]
        public Guid TicketID { get; set; }

        public string Message { get; set; }
        public List<Models.Ticket> tickets = new List<Models.Ticket>();

        public void OnGet()
        {
            DataTable ticketsDt = Call.Calls.GetTickets().GetAwaiter().GetResult();

            foreach (DataRow row in ticketsDt.Rows)
            {
                Models.Ticket ticket = new Models.Ticket();

                ticket.ID = Guid.Parse(row.ItemArray[0].ToString());
                ticket.Price = decimal.Parse(row.ItemArray[1].ToString());

                tickets.Add(ticket);
            }
        }

        public ActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Models.Linhas newLinha = new Models.Linhas();
                Models.Ticket ticket = new Models.Ticket();
                newLinha.Number = number.Trim().ToLower();
                newLinha.Description = description.Trim().ToLower();
                ticket.ID = TicketID;
                newLinha.Ticket = ticket;

                if (Call.Calls.CreateLines(newLinha).Result)
                {
                    return RedirectToPage("Linhas");
                }
                else
                {
                    Message = "Erro ao realizar operação!";
                    return Page();
                }
            }
            else { return Page(); }
        }
    }
}