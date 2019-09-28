using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazor.Pages.Linhas
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Guid lineID { get; set; }
        [BindProperty]
        public Guid ticketID { get; set; }
        [BindProperty]
        public string number { get; set; }
        [BindProperty]
        public string description { get; set; }

        public string Message;

        public List<Models.Ticket> tickets = new List<Models.Ticket>();

        public void OnGet(Guid id)
        {
            DataTable lineDt = Call.Calls.GetLinesById(id).GetAwaiter().GetResult();
            DataTable ticketsDt = Call.Calls.GetTickets().GetAwaiter().GetResult();

            foreach (DataRow row in lineDt.Rows)
            {
                lineID = Guid.Parse(row.ItemArray[0].ToString());
                number = row.ItemArray[1].ToString().ToUpper();
                description = row.ItemArray[2].ToString().ToUpper();
            }

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
            Models.LinhasAlter linhas = new Models.LinhasAlter();
            Models.Ticket ticket = new Models.Ticket();
            linhas.ID = lineID;
            linhas.Number = number.Trim().ToUpper();
            linhas.Description = description.Trim().ToUpper();
            linhas.Alter_Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ticket.ID = ticketID;
            ticket.Alter_Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            linhas.Ticket = ticket;
            linhas.UserID = Guid.Parse(HttpContext.Session.GetString("SessionUid"));

            if (ModelState.IsValid)
            {
                if (Call.Calls.EditLines(linhas).Result)
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