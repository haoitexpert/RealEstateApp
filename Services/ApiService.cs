using Newtonsoft.Json;
using RealEstateApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateApp.Services
{
    public class ApiService
    {
        public async Task<bool> RegisterUser(string name, string email, string password, string phone)
        {
            var register = new Register()
            {
                Name = name,
                Email = email,
                Password = password,
                Phone = phone
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(register);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://realestateapp001-c8bzdvckcef3h6cw.southeastasia-01.azurewebsites.net/api/users/register", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
            
        }
    }
}
