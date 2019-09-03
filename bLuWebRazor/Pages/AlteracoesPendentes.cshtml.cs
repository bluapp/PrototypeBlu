using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bLuWebRazor.Pages
{
    public class AlteracoesPendentesModel : PageModel
    {
        public List<Models.LinhasAlter> alters = new List<Models.LinhasAlter>();
        public string msg;

        public void OnGet()
        {
            DataTable alterDt = Call.Calls.GetAltersToAprove().GetAwaiter().GetResult();
            Models.LinhasAlter linhas;
            Models.Ticket ticket;

            for (int i = 0; i < alterDt.Rows.Count; i++)
            {
                linhas = new Models.LinhasAlter();
                linhas.Ticket = new Models.Ticket();

                linhas.Number = alterDt.Rows[i]["number"].ToString();
                linhas.Ticket.ID = Guid.Parse(alterDt.Rows[i]["ticket_id"].ToString());
                linhas.Ticket.Price = decimal.Parse(alterDt.Rows[i]["price"].ToString());
                linhas.ID = Guid.Parse(alterDt.Rows[i]["line_id"].ToString());
                linhas.Alter_Date = DateTime.Parse(alterDt.Rows[i]["alter_date"].ToString()).ToString("dd/MM/yyyy");
                linhas.Description = alterDt.Rows[i]["description"].ToString();
                linhas.Alter_ID = Guid.Parse(alterDt.Rows[i]["id"].ToString());
                linhas.Status = alterDt.Rows[i]["status"].ToString();

                alters.Add(linhas);
            }
        }

        public IActionResult OnPost(Guid id)
        {
            if (Call.Calls.AproveEditLines(id).GetAwaiter().GetResult())
            {
                return RedirectToPage("AlteracoesPendentes");
            }
            else
            {
                msg = "Tivemos um problema ao aprovar esta alteração, tente novamente!";
                return RedirectToPage("AlteracoesPendentes");
            }
        }

        public IActionResult OnPostCancelar(Guid id)
        {
            if (Call.Calls.RejectEditLines(id).GetAwaiter().GetResult()) { return RedirectToPage("AlteracoesPendentes"); }
            else
            {
                msg = "Tivemos um problema ao cancelar esta alteração, tente novamente!";
                return RedirectToPage("AlteracoesPendentes");
            }
        }
    }
}