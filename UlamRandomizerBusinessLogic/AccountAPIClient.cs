using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UlamCommon;
namespace UlamRandomizerBusinessLogic
{
    public class AccountAPIClient
    {
        private readonly HttpClient _httpClient;

        public AccountAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7046/api/Accounts");
        }

        public async Task<bool> ConfirmLogin(string username, string password)
        {
            try{
                Console.WriteLine("Attempting to confirm login...");
                var response = await _httpClient.GetAsync($"{_httpClient.BaseAddress}/ConfirmLogin?Username={username}&Password={password}");
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return bool.Parse(result);
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }


        }
        public async Task<bool> DoesAccountExists(string Email)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_httpClient.BaseAddress}/DoesAccountExist?email={Email}");
                if (response.IsSuccessStatusCode)
                {
                    return bool.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exist)
            {
                throw new Exception($"Account does not exist: {exist.Message}");
            }


        }

        public async Task AddAccount(string username, string password, string email, string firstName, string lastName, string Gender, DateOnly Birthday)
        {

            try
            {
                var response = await _httpClient.PostAsJsonAsync($"{_httpClient.BaseAddress}/AddAccount?" +
                $"Username={username}&Password={password}&email={email}&Firstname={firstName}&Lastname={lastName}&Gender={Gender}&Birthday={Birthday}", "");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Account Created!");
                }
                else
                {
                    Console.WriteLine("Failed to create account.");
                }
            }
            catch (Exception add)
            {

                throw new Exception($"Failed to add the account: {add.Message}");
            }
            
        }

    }
}
