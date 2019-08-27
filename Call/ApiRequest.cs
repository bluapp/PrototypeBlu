using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Call
{
    public static class ApiRequest
    {
        public static async Task<T> PostAsync<T>(string tokenacesso, string controller, object objeto)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("token", tokenacesso);
                client.BaseAddress = new Uri("https://localhost:5000/api/");
                client.Timeout = TimeSpan.FromMinutes(10);
                var res = client.PostAsJsonAsync(controller, objeto).Result;
                if (res.IsSuccessStatusCode)
                {
                    var ret = await res.Content.ReadAsAsync<T>();
                    return ret;
                }
                if (res.StatusCode == System.Net.HttpStatusCode.Conflict || res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    throw new Exception(System.Web.HttpUtility.HtmlDecode(res.Headers.GetValues("ErrorMessage").FirstOrDefault()));
                return default(T);
            }
        }

        public static async Task<T> GetAsync<T>(string tokenacesso, string controller)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("token", tokenacesso);
                client.BaseAddress = new Uri("https://localhost:3001/api/");
                client.Timeout = TimeSpan.FromMinutes(10);
                var res = client.GetAsync(controller).Result;
                if (res.IsSuccessStatusCode)
                {
                    var ret = await res.Content.ReadAsAsync<T>();
                    return ret;
                }
                if (res.StatusCode == System.Net.HttpStatusCode.Conflict)
                    throw new Exception(System.Web.HttpUtility.HtmlDecode(res.Headers.GetValues("ErrorMessage").FirstOrDefault()));
                return default(T);
            }
        }
    }
}
