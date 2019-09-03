using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Call;
using Microsoft.AspNetCore.Http;
using System.Data;
using WebRazor;

namespace bLuWebRazor.Pages
{
    public class LoginModel : MyPageModel
    {
        [BindProperty]
        public string Login { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public string msg;

        public void OnGet()
        {

        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.SetString("SessionUid", string.Empty);
            HttpContext.Session.SetString("SessionNome", string.Empty);
            HttpContext.Session.SetString("SessionLogin", string.Empty);
            HttpContext.Session.SetString("SessionPermission", string.Empty);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            DataTable usuario = await Calls.Logar(Login, Password);

            if (usuario != null)
            {
                foreach (DataRow row in usuario.Rows)
                {
                    HttpContext.Session.SetString("SessionUid", row.ItemArray[0].ToString());
                    HttpContext.Session.SetString("SessionNome", row.ItemArray[1].ToString());
                    HttpContext.Session.SetString("SessionLogin", row.ItemArray[2].ToString());
                    HttpContext.Session.SetString("SessionPermission", row.ItemArray[3].ToString());
                }

                if (HttpContext.Session.GetString("SessionPermission").ToUpper() == "ADM") { return RedirectToPage("Menu"); }
                else { return RedirectToPage("MenuComum"); }
            }
            else
            {
                msg = "Login ou senha inválidos!";
                return Page();
            }
        }
    }
}