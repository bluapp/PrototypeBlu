using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazor.Pages
{
    public class MenuModel : MyPageModel
    {
        public string permission;
        public IActionResult OnGet()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("SessionUid"))) { return RedirectToPage("Login"); }
            else
            {
                permission = HttpContext.Session.GetString("SessionPermission");
                return Page();
            }
        }
    }
}