using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace basic_auth.AuthorizationRequirements
{
    public class CustomRequireClaim : IAuthorizationRequirement
    {
        public CustomRequireClaim(string claimType)
        {
            ClaimType = claimType;
        }

        public string ClaimType { get; private set; }
    }

    public class CustomRequireClaimHandler : AuthorizationHandler<CustomRequireClaim>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomRequireClaim requirement)
        {
            var hasClaim = context.User.Claims.Any(x => x.Type == requirement.ClaimType);
            if (hasClaim)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }


    // Extension
    public static class AuthorizationPolicyBuilderExtensions
    {
        public static AuthorizationPolicyBuilder RequireCustomClaim(
            this AuthorizationPolicyBuilder builder,
            string claimType
        )
        {
            builder.AddRequirements(new CustomRequireClaim(claimType));

            return builder;
        }
    }
}
