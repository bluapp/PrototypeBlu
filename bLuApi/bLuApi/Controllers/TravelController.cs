using System;
using System.Data;
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
        public async Task<TravelUser> RegisterTravel([FromRoute] string code, [FromRoute] string user_id)
        {
            Travel travel = GetOpenTravel(code, user_id);
            return InsertTravel(travel, user_id);
        }

        [Route("Receipt/{userId}/{travelId}")]
        [HttpGet]
        public object Receipt([FromRoute] string userId, string travelId)
        {
            var user = new UsuariosController().GetUserById(userId);
            var enterprise = new EnterpriseController().GetEnterpriseInfo(travelId);
            var travelUser = GetTravelInfo(userId, travelId);

            return new {
                id = travelUser.id,
                register_date = travelUser.register_date,
                price = travelUser.price_ticket,
                user_id = user.ID,
                name = user.Nome,
                email = user.Email,
                city = enterprise.city, 
                uf = enterprise.uf, 
                enterprise_name = enterprise.name, 
                enterprise_individual_registration = enterprise.individual_registration,
            };
        }

        private Travel GetOpenTravel(string code, string userId)
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

                DataRow[] rows = dt.Select(); 
                return LoadAttributes(rows);
            }
            catch (Exception e)
            {
                bd.FecharConexao();
                throw new Exception(e.Message, e);
            }
        }

        public TravelUser InsertTravel(Travel travel, string userId)
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
                
                return GetTravelInfo(userId, travel.id);;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        
        private TravelUser GetTravelInfo(string userId, string travelId)
        {
            DAL bd = new DAL();
            TravelUser travel = new TravelUser();
            try
            {
                DataTable dt = new DataTable();
                string sql = $@"select t.id, t.user_id, t.travel_id, t.register_date, t.price_ticket
                                    from travel_user as t
                                inner join user u on t.user_id = u.id
                                where t.travel_id = '{travelId}'
                                    and t.user_id = '{userId}'
                                order by t.register_date desc
                                limit 1";
                dt = bd.RetDataTable(sql);
                bd.FecharConexao();

                DataRow[] rows = dt.Select(); 
                return LoadAttributesTravelUser(rows);
            }
            catch (Exception e)
            {
                bd.FecharConexao();
                throw new Exception(e.Message, e);
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

        private TravelUser LoadAttributesTravelUser(DataRow[] rows)
        {
            TravelUser obj = new TravelUser();
            foreach (var row in rows)
            {
                obj.id = row["id"].ToString();
                obj.user_id = row["user_id"].ToString();
                obj.travel_id = row["travel_id"].ToString();
                obj.register_date = Convert.ToDateTime(row["register_date"].ToString());
                obj.price_ticket = (decimal)row["price_ticket"];
            }
            return obj;
        }
    }
    public class TravelUser
    {
        public string id {get; set;} 
        public string user_id {get; set;} 
        public string travel_id {get; set;} 
        public DateTime register_date {get; set;}
        public decimal price_ticket {get; set;}
    }
}