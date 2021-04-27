using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components.Authorization;

using PlannerApp.Models;

namespace PlannerApp.Client
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService storageService;

        public LocalAuthenticationStateProvider(ILocalStorageService localStorage)
        {
            storageService = localStorage;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if(await storageService.ContainKeyAsync("User"))
            {
                var userInfo = await storageService.GetItemAsync<LocalUserInfo>("User");
                var claims = new[]
                {
                    new Claim("Email", userInfo.Email),
                    new Claim("FirstName", userInfo.FirstName),
                    new Claim("LastName", userInfo.LastName),
                    new Claim("AccessToken", userInfo.LastName),
                    new Claim(ClaimTypes.NameIdentifier, userInfo.Id)
                };
                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);

                return new AuthenticationState(user);
            }

            return new AuthenticationState(new System.Security.Claims.ClaimsPrincipal());
        }
    }
}
