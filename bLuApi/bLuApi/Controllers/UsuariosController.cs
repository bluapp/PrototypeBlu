﻿using System;
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
    }
}
