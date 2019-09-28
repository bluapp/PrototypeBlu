using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

            if (alterDt != null)
            {
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
                    linhas.UserID = Guid.Parse(HttpContext.Session.GetString("SessionUid"));

                    alters.Add(linhas);
                }
            }
        }

        public IActionResult OnPost(Guid id)
        {
            Models.LinhasAlter linhas = new Models.LinhasAlter();
            linhas.Alter_ID = id;
            linhas.UserID = Guid.Parse(HttpContext.Session.GetString("SessionUid"));

            if (Call.Calls.AproveEditLines(linhas).GetAwaiter().GetResult())
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
            Models.LinhasAlter linhas = new Models.LinhasAlter();
            linhas.Alter_ID = id;
            linhas.UserID = Guid.Parse(HttpContext.Session.GetString("SessionUid"));

            if (Call.Calls.RejectEditLines(linhas).GetAwaiter().GetResult()) { return RedirectToPage("AlteracoesPendentes"); }
            else
            {
                msg = "Tivemos um problema ao cancelar esta alteração, tente novamente!";
                return RedirectToPage("AlteracoesPendentes");
            }
        }
    }
}