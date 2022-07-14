using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            // Registra automaticamente los mapeos que se hagan en esta biblioteca de clase
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // Registra que las validaciones se van a hacer en esta biblioteca de clases
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // Permite la referencia
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
