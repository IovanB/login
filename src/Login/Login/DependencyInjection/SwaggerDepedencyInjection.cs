using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Login.API.DependencyInjection
{
    public static class SwaggerDepedencyInjection
    {
        public static IServiceCollection Swagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Login API", Version = "v1" });
            });

            return services;
        }
    }
}
