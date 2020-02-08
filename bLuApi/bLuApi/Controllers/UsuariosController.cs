using System;
using System.Collections.Generic;
using System.Linq;
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

        [Route("GetUser/{uid}")]
        [HttpGet]
        public async Task<DataTable> GetUser([FromRoute] Guid uid)
        {
            DAL bd = new DAL();
            string sql = $"select * from user_enterprise where id = {uid}";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("Logar/{login}/{password}")]
        [HttpGet]
        public async Task<DataTable> Logar([FromRoute] string login, [FromRoute] string password)
        {
            DAL bd = new DAL();
            DataTable dt = new DataTable();
            try
            {
                string sql = $"select u.id, u.name, lu.login, u.permission from " +
                    $"login_user_enterprise as lu inner join user_enterprise as u on " +
                    $"lu.user_enterprise_id = u.id where lu.login = '{login}' and lu.password = '{password}'";
                dt = bd.RetDataTable(sql);
                bd.FecharConexao();

                if (dt.Rows.Count != 0) { return dt; }
                else { return null; }
            }
            catch
            {
                bd.FecharConexao();
                return null;
            }
        }

        [Route("GetRelatorioConsolidado")]
        [HttpGet]
        public async Task<DataTable> GetRelatorioConsolidado()
        {
            DAL bd = new DAL();
            DataTable dt = new DataTable();

            try
            {
                string sql = "select qr.code as qrCode, qr.active as status, b.code as busCode, b.license_plate, " +
                                "t.start_time, t.finish_time, t.active as status, count(distinct(tu.user_id)) as qtde_usuarios, count(tu.user_id) as qtde_bilhetes, tu.price_ticket as ticket_price, sum(tu.price_ticket) as total_price, " +
                                "l.number as line, d.name as driver " +
                                "from qr_code as qr " +
                                "inner join car as b on qr.code = b.code " +
                                "inner join travel as t on b.id = t.car_id " +
                                "inner join travel_user as tu on t.id = tu.travel_id " +
                                "inner join line as l on t.bus_line_id = l.id " +
                                "inner join driver as d on t.driver_id = d.id " +
                                "where qr.active;";
                dt = bd.RetDataTable(sql);
                bd.FecharConexao();

                if (dt.Rows.Count != 0) { return dt; }
                else { return null; }
            }
            catch (Exception ex)
            {
                bd.FecharConexao();
                return null;
            }
        }

        [Route("GetRelatorioByCar")]
        [HttpGet]
        public async Task<DataTable> GetRelatorioByCar()
        {
            DAL bd = new DAL();
            DataTable dt = new DataTable();

            try
            {
                string sql = "select qr.code as qrcode, b.code, b.license_plate, " +
                                "tu.id as travel_user, tu.user_id as travel_user_id, u.name as user_name, t.id as travel_id, t.start_time, t.finish_time, l.number as line, d.name as driver_name, tu.price_ticket " +
                                "from car as b " +
                                "inner join qr_code as qr on b.code = qr.code " +
                                "inner join travel as t on b.id = t.car_id " +
                                "inner join travel_user as tu on t.id = tu.travel_id " +
                                "inner join user as u on tu.user_id = u.id " +
                                "inner join line as l on t.bus_line_id = l.id " +
                                "inner join driver as d on t.driver_id = d.id " +
                                $"where qr.active; ";
                dt = bd.RetDataTable(sql);
                bd.FecharConexao();

                if (dt.Rows.Count != 0) { return dt; }
                else { return null; }
            }
            catch (Exception ex)
            {
                bd.FecharConexao();
                return null;
            }
        }
    }
}
