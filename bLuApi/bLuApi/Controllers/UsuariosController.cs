using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using API.Models;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [Route("TaFuncionando")]
        [HttpGet]
        public async Task<Status> TaFuncionando()
        {
            Status status = new Status();
            status.Texto = "Estou!";
            return status;
        }

        [Route("GetBdStatus")]
        [HttpGet]
        public async Task<DAL> GetBdStatus()
        {
            DAL bd = new DAL();
            return bd;
        }

        [Route("GetUsers")]
        [HttpGet]
        public async Task<DataTable> GetUsers()
        {
            DAL bd = new DAL();
            string sql = "select * from user";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("GetUserById")]
        [HttpGet]
        public Usuarios GetUserById(string id)
        {
            DAL bd = new DAL();
            string sql = $@"select * from user
                            where id = '{id}'";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
                        
            DataRow[] rows = dt.Select(); 
            return LoadAttributes(rows);
        }

        [Route("Logar/{login}/{password}")]
        [HttpGet]
        public async Task<DataTable> Logar([FromRoute] string login, [FromRoute] string password)
        {
            DAL bd = new DAL();
            DataTable dt = new DataTable();
            try
            {
                string sql = $"select * from login_user where login = '{login}' and password = '{password}'";
                dt = bd.RetDataTable(sql);
                bd.FecharConexao();
                return dt;
            }
            catch 
            {
                bd.FecharConexao();
                return dt;
            }
        }

        private Usuarios LoadAttributes(DataRow[] rows)
        {
            var obj = new Usuarios();
            foreach (var row in rows)
            {
                obj.ID = row["id"].ToString();
                obj.Nome = row["name"].ToString();
                obj.DtNasc = row["birth_date"].ToString();
                obj.Email = string.IsNullOrEmpty(row["email"].ToString()) ? null : row["email"].ToString();
            }
            return obj;
        }
    }
}
