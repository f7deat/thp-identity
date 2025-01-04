using Microsoft.Extensions.DependencyInjection;
using THPIdentity.Interfaces;
using THPIdentity.Services;

namespace THPIdentity;

public static class IdentityServiceCollectionExtensions
{
    public static void AddIdentityServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}
