using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using AKSoftware.WebApi.Client;

using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Services
{
    public class AuthenticationService
    {
        private readonly string baseUrl;
        ServiceClient client = new ServiceClient();

        public AuthenticationService(string url)
        {
            baseUrl = url;
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{baseUrl}/api/auth/register", request);
            return response.Result;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{baseUrl}/api/auth/login", request);
            return response.Result;
        }
    }
}
