using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Call.ApiRequest;
using Models;
using System.Data;

namespace Call
{
    public static class Calls
    {
        public async static Task<Status> GetBdStatus()
        {
            return await GetAsync<Status>("", "usuarios/GetBdStatus");
        }

        public async static Task<DataTable> GetUsers()
        {
            return await GetAsync<DataTable>("", "usuarios/GetUsers");
        }

        public async static Task<DataTable> Logar(string login, string password)
        {
            return await GetAsync<DataTable>("", $"usuarios/Logar/{login}/{password}");
        }

        public async static Task<DataTable> GetLinesLimited()
        {
            return await GetAsync<DataTable>("", "Linhas/GetLinesLimited");
        }

        public async static Task<DataTable> GetLines()
        {
            return await GetAsync<DataTable>("", "Linhas/GetLines");
        }

        public async static Task<DataTable> GetLinesById(Guid id)
        {
            return await GetAsync<DataTable>("", $"Linhas/GetLinesByID/{id}");
        }

        public async static Task<DataTable> SearchLines(string busca)
        {
            return await GetAsync<DataTable>("", $"Linhas/SearchLines/{busca}");
        }

        public async static Task<bool> EditLines(Linhas linha)
        {
            return await PostAsync<bool>("", "Linhas/EditLines", linha);
        }

        public async static Task<bool> CreateLines(Linhas newLinha)
        {
            return await PostAsync<bool>("", $"Linhas/CreateLines", newLinha);
        }

        public async static Task<DataTable> GetTickets()
        {
            return await GetAsync<DataTable>("", $"Tickets/GetTickets");
        }
    }
}
