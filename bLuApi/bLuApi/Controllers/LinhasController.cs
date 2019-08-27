using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [EnableCors("MyPolicy")]
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
        public bool EditLines([FromBody] Linhas linhas)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $"update line as l set l.number = {linhas.Number}, l.description = '{linhas.Description}', l.ticket_id = '{linhas.Ticket.ID}', l.alter_date = '{linhas.Alter_Date}' where l.id = '{linhas.ID}'";
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
    }
}