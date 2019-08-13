using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazor.Pages.Linhas
{
    public class LinhasModel : PageModel
    {
        public Models.Linhas lines;
        public List<Models.Linhas> linhas = new List<Models.Linhas>();

        [BindProperty]
        public string busca { get; set; }

        public void OnGet()
        {
            PreencherListaLinhas(Call.Calls.GetLinesLimited().GetAwaiter().GetResult());   
        }

        public void OnPostBuscar()
        {
            if (!String.IsNullOrEmpty(busca)) { PreencherListaLinhas(Call.Calls.SearchLines(busca).GetAwaiter().GetResult()); }
            else { PreencherListaLinhas(Call.Calls.GetLinesLimited().GetAwaiter().GetResult()); }
        }

        public void OnPostMostrarTudo()
        {
            PreencherListaLinhas(Call.Calls.GetLines().GetAwaiter().GetResult());
        }

        public void PreencherListaLinhas(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                lines = new Models.Linhas();
                Models.Ticket ticket = new Models.Ticket();

                lines.ID = Guid.Parse(row.ItemArray[0].ToString());
                lines.Number = row.ItemArray[1].ToString();
                lines.Description = row.ItemArray[2].ToString();
                ticket.ID = Guid.Parse(row.ItemArray[3].ToString());
                ticket.Price = decimal.Parse(row.ItemArray[4].ToString());
                lines.Ticket = ticket;

                linhas.Add(lines);
            }
        }
    }
}