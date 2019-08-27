using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRazor
{
    public class MyPageModel : PageModel
    {
        public UsuarioLogado usuarioLogado;

        public MyPageModel()
        {
            usuarioLogado = new UsuarioLogado(this);
        }

        private Dictionary<string, string> _valores = new Dictionary<string, string>();

        /// <summary>
        /// Carrega um valor que foi gravado antes, e mantém o valor salvo.
        /// </summary>
        public string GetValue(string key)
        {
            if (_valores.ContainsKey(key))
                return _valores[key];
            else
                return _valores[key] = Request.Cookies[key];
        }

        /// <summary>
        /// Grava um valor em cookie e na memoria. Se não colocar expiracao ele expira junto com a sessao do browser.
        /// </summary>
        public void SaveValue(string key, object value, int? diasateexpirar)
        {
            value = value?.ToString() + "";
            Response.Cookies.Delete(key);
            CookieOptions option = new CookieOptions();
            option.IsEssential = true;
            option.Expires = null;
            if (diasateexpirar != null)
            {
                option.IsEssential = true;
                option.Expires = DateTime.Now.AddDays(diasateexpirar.Value);
            }
            Response.Cookies.Append(key, value.ToString(), option);
            if (_valores.ContainsKey(key))
                _valores[key] = value.ToString();
            else
                _valores.Add(key, value.ToString());
        }
    }
}
