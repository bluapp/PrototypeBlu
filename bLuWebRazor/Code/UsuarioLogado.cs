using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebRazor
{
    public class UsuarioLogado
    {
        private MyPageModel _page;

        public UsuarioLogado(MyPageModel page)
        {
            _page = page;
        }

        public bool EstaLogado()
        {
            return !string.IsNullOrEmpty(tokenlogin);
        }

        public async Task<bool> LogarUsuario(string email, string senha)
        {
            var usuariologado = await Call.Calls.Logar(email, senha);
            if (usuariologado != null)
            {
                foreach (DataRow row in usuariologado.Rows)
                {
                    tokenuid = Guid.Parse(row.ItemArray[0].ToString());
                    tokennome = row.ItemArray[1].ToString();
                    tokenlogin = row.ItemArray[2].ToString();
                }
                return true;
            }
            else
                return false;
        }

        public void DesLogarUsuario()
        {
            tokenuid = Guid.Empty;
            tokennome = null;
            tokenlogin = null;
        }

        public string tokenlogin
        {
            get
            {
                return _page.GetValue("tokenlogin");
            }
            set
            {
                _page.SaveValue("tokenlogin", value, null);
            }
        }

        public Guid tokenuid
        {
            get
            {
                if (_page.GetValue("tokenuid") == null) return Guid.Empty;
                return new Guid(_page.GetValue("tokenuid"));
            }
            set
            {
                _page.SaveValue("tokenuid", value, null);
            }
        }

        public string tokennome
        {
            get
            {
                return _page.GetValue("tokennome");
            }
            set
            {
                _page.SaveValue("tokennome", value, null);
            }
        }
    }


}
