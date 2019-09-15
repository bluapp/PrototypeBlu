using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        [Route("RegisterTravel/{code}/{user_id}")]
        [HttpGet]
        public async Task<bool> RegisterTravel([FromRoute] string code, [FromRoute] string user_id)
        {
            return GetTravelInformations(code, user_id);
        }

        private bool GetTravelInformations(string code, string userId)
        {
            DAL bd = new DAL();
            Travel travel = new Travel();
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select t.id, t.active, t.start_time, t.finish_time, t2.price, l.number, c.code
                                    from travel as t
                                inner join line_car as lc on lc.line_id = t.bus_line_id
                                inner join line l on lc.line_id = l.id
                                inner join ticket t2 on l.ticket_id = t2.id
                                inner join car c on lc.car_id = c.id
                                where t.active and c.code = {code} 
                                    and now() > t.start_time 
                                    and t.finish_time is null;";
                dt = bd.RetDataTable(sql);
                bd.FecharConexao();

                DataRow[] rows= dt.Select(); 
                travel = LoadAttributes(rows);

               return InsertTravel(travel, userId);

            }
            catch (Exception e)
            {
                bd.FecharConexao();
                return false;
            }
        }

        private Travel LoadAttributes(DataRow[] rows)
        {
            Travel travel = new Travel();
            foreach (var row in rows)
            {
                travel.id = row["id"].ToString();
                travel.active = row["active"].ToString() == "1" ? true : false;
                travel.start_time = row["start_time"].ToString();
                travel.finish_time = string.IsNullOrEmpty(row["finish_time"].ToString()) ? null : row["finish_time"].ToString();
                travel.price = (decimal)row["price"];
                travel.number = row["number"].ToString();
                travel.code = row["code"].ToString();
            }
            return travel;
        }

        public bool InsertTravel(Travel travel, string userId)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $@"insert into travel_user (
                                    id, user_id, travel_id, register_date, price_ticket
                                )
                                values (
                                    uuid(), '{userId}', '{travel.id}', now(), {travel.price}
                                );";
                                
                bd.ExecutarComandoSQL(sql);
                bd.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Receipt()
        {

        }
    }
}