using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinhasController : ControllerBase
    {
        [Route("GetLinesLimited")]
        [HttpGet]
        public async Task<DataTable> GetLinesLimited()
        {
            DAL bd = new DAL();
            string sql = "select l.id, l.number, l.description, l.ticket_id, t.price from line as l inner join ticket as t on l.ticket_id = t.id order by l.description limit 10";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("GetLines")]
        [HttpGet]
        public async Task<DataTable> GetLines()
        {
            DAL bd = new DAL();
            string sql = "select l.id, l.number, l.description, l.ticket_id, t.price from line as l inner join ticket as t on l.ticket_id = t.id order by l.description";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("GetLinesByID/{id}")]
        [HttpGet]
        public async Task<DataTable> GetLinesByID([FromRoute] Guid id)
        {
            DAL bd = new DAL();
            string sql = $"select l.id, l.number, l.description, l.ticket_id, t.price from line as l inner join ticket as t on l.ticket_id = t.id where l.id = '{id}'";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("SearchLines/{busca}")]
        [HttpGet]
        public async Task<DataTable> SearchLines([FromRoute] string busca)
        {
            DAL bd = new DAL();
            string sql = $"select l.id, l.number, l.description, l.ticket_id, t.price from line as l inner join ticket as t on l.ticket_id = t.id where number like '%{busca}%' or description like '%{busca}%';";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("EditLines")]
        [HttpPost]
        public bool EditLines([FromBody] LinhasAlter linhas)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $"insert into historic_line values(uuid(), '{linhas.Number}', '{linhas.Ticket.ID}', '{linhas.ID}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{linhas.Description}', 'PENDENTE', '{linhas.UserID}', null)";
                bd.ExecutarComandoSQL(sql);
                bd.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [Route("CreateLines")]
        [HttpPost]
        public async Task<bool> CreateLines([FromBody] Linhas newLinha)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $"insert into line values (uuid(), '{newLinha.Number}', '{newLinha.Ticket.ID}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{newLinha.Description}')";
                bd.ExecutarComandoSQL(sql);
                bd.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [Route("GetAltersToAprove")]
        [HttpGet]
        public async Task<DataTable> GetAltersToAprove()
        {
            DAL bd = new DAL();
            DataTable dt = bd.RetDataTable("select * from historic_line inner join ticket on ticket.id = historic_line.ticket_id where status = 'PENDENTE'");
            bd.FecharConexao();
            return dt;

        }

        [Route("AproveEditLines")]
        [HttpPost]
        public async Task<bool> AproveEditLines([FromBody] LinhasAlter linhas)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $"update historic_line set status = 'APROVADO', alter_date = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', aprove_user = '{linhas.UserID}' where id = '{linhas.Alter_ID}'";
                bd.ExecutarComandoSQL(sql);
                sql = $"update line set number = (select number from historic_line where id = '{linhas.Alter_ID}')," +
                        $" ticket_id = (select ticket_id from historic_line where id = '{linhas.Alter_ID}')," +
                        $" description = (select description from historic_line where id = '{linhas.Alter_ID}')," +
                        $" alter_date = NOW()" +
                        $" where id = (select line_id from historic_line where id = '{linhas.Alter_ID}')";
                bd.ExecutarComandoSQL(sql);
                bd.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [Route("RejectEditLines")]
        [HttpPost]
        public async Task<bool> RejectEditLines([FromBody] LinhasAlter linhas)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $"update historic_line set status = 'CANCELADO', alter_date = NOW(), aprove_user = '{linhas.UserID}' where id = '{linhas.Alter_ID}'";
                bd.ExecutarComandoSQL(sql);
                bd.FecharConexao();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}