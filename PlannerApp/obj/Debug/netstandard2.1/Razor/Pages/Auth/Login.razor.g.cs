#pragma checksum "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4fb209c7fafc3f73b484accecaf5462a72a0d1"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using PlannerApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h2>Login to your account</h2>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                         loginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                      LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenComponent<PlannerApp.Client.Shared.AlertMessage>(15);
                    __builder3.AddAttribute(16, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                        message

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "MessageType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PlannerApp.Models.AlertMessageType>(
#nullable restore
#line 15 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                               messageType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(19, "<ul>\r\n                </ul>\r\n\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(22);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(24, "<label>Email Name</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(25);
                    __builder3.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                          loginRequest.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Email = __value, loginRequest.Email))));
                    __builder3.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n\r\n                ");
                    __builder3.AddMarkupContent(30, "<label>Password</label>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(31);
                    __builder3.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                           loginRequest.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Password = __value, loginRequest.Password))));
                    __builder3.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n\r\n                <hr>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(36);
                    __builder3.AddAttribute(37, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 34 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                        Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Text", "Login");
                    __builder3.AddAttribute(39, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 35 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                         Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "class", "btn-block mr-2");
                    __builder3.AddAttribute(41, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                                                                                      isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(43);
                    __builder3.AddAttribute(44, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 36 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                        Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Text", "Register");
                    __builder3.AddAttribute(46, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 37 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                         Radzen.ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "class", "btn-block mr-2");
                    __builder3.AddAttribute(48, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                                                                                        isBusy

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
                                                                                                                                       GoToRegister

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\rji8\Documents\Visual Studio 2019\Projects\PlannerApp\PlannerApp\Pages\Auth\Login.razor"
       
    LoginRequest loginRequest = new LoginRequest();
    AlertMessageType messageType = AlertMessageType.Success;
    string message = string.Empty;
    bool isBusy;

    public async Task LoginUser()
    {
        isBusy = true;
        var response = await authService.LoginUserAsync(loginRequest);
        if (response.IsSuccess)
        {
            message = "Welcome to Planner App";
            messageType = AlertMessageType.Success;

            var userInfo = new LocalUserInfo()
            {
                AccessToken = response.Message,
                Email = response.UserInfo["Email"],
                FirstName = response.UserInfo["FirstName"],
                LastName = response.UserInfo["LastName"],
                Id = response.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier],
            };
            await storageService.SetItemAsync<LocalUserInfo>("User", userInfo);
        }
        else
        {
            message = response.Message;
            messageType = Models.AlertMessageType.Error;
        }
        isBusy = false;
    }

    public void GoToRegister()
    {
        navigationManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
