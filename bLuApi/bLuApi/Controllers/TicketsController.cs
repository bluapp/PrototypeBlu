using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [Route("GetTickets")]
        [HttpGet]
        public async Task<DataTable> GetTickets()
        {
            DAL bd = new DAL();
            string sql = "select t.id, t.price from ticket as t";
            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }
    }
}