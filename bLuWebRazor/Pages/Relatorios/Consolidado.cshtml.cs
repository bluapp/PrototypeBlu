using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Call;

namespace bLuWebRazor.Pages.Relatorios
{
    public class ConsolidadoModel : PageModel
    {
        public DataTable consolidadoDT = new DataTable();

        public void OnGet()
        {
            consolidadoDT = Calls.GetRelatorioConsolidado().GetAwaiter().GetResult();
        }
    }
}