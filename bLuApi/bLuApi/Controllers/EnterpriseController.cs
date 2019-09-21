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
    public class EnterpriseController : ControllerBase
    {
        [Route("RegisterTravel/{code}/{user_id}")]
        [HttpGet]
        public Enterprise GetEnterpriseInfo(string travelId)
        {
            DAL bd = new DAL();
            var enterprise = new Enterprise();
            try
            {
                string sql = $@"select e.id, c.name as city, s.uf, e.name, 
                                       e.individual_registration
                                    from enterprise as e
                                inner join driver d on e.id = d.enterprise_id
                                inner join travel t on d.id = t.driver_id
                                inner join city c on e.city_id = c.id
                                inner join state s on c.state_id = s.id
                                where t.id = '{travelId}';";
                DataTable dt = new DataTable();
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

        private Enterprise LoadAttributes(DataRow[] rows)
        {
            var obj = new Enterprise();
            foreach (var row in rows)
            {
                obj.id = row["id"].ToString();
                obj.name = row["name"].ToString();
                obj.individual_registration = row["individual_registration"].ToString();
                obj.city = row["city"].ToString(); 
                obj.uf = row["uf"].ToString();
            }
            return obj;
        }
    }
}