using System;
using System.Data;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace bLuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [Route("GetByUserId/{userId}")]
        [HttpGet]
        public async Task<DataTable> GetByUserId([FromRoute] string userId)
        {
            DAL bd = new DAL();

            string sql = $@"select w.id, w.cash, w.register_date, w.alter_date, w.user_id
                            from wallet as w
                            inner join login_user u on w.user_id = u.user_id
                            where u.user_id = '{userId}'";

            DataTable dt = bd.RetDataTable(sql);
            bd.FecharConexao();
            return dt;
        }

        [Route("UpdateCash/{walletId}/{price}")]
        [HttpGet]
        public async Task<bool> UpdateCash([FromRoute] string walletId, [FromRoute] decimal price)
        {
            DAL bd = new DAL();

            try
            {
                string sql = $@"update wallet
                                set cash = cash - {price.ToString()}
                                where id = '{walletId}';";

                sql = sql.Replace(",", ".");

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