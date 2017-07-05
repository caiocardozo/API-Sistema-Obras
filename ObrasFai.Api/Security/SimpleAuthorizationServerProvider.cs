﻿using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using ObrasFai.Domain.Services.Administration;

namespace ObrasFai.Api.Security
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        IUserApplicationService _userService;

        public SimpleAuthorizationServerProvider(IUserApplicationService userService)
        {
            this._userService = userService;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var user = _userService.Authenticate(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("invalid_grant", "Usuário ou senha inválidos");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            identity.AddClaim(new Claim(ClaimTypes.Name, user.Username));
            ///identity.AddClaim(new Claim(ClaimTypes.Role, user.IsAdmin ? "admin" : ""));
            var admin = true; //arrumar aqui
            GenericPrincipal principal = new GenericPrincipal(identity, new string[] { admin ? "admin" : "" });
            Thread.CurrentPrincipal = principal;

            context.Validated(identity);
        }
    }
}