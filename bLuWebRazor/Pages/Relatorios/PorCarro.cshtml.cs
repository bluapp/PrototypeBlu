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
    public class PorCarroModel : PageModel
    {
        public DataTable relatorioDT = new DataTable();
        public string busca;
        public void OnGet()
        {
            relatorioDT = Calls.GetRelatorioByCar().GetAwaiter().GetResult();
        }
    }
}