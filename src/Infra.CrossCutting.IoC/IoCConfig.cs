using Application.Handlers;
using Infra.Data.Contexts;
using Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;
using SharedKernel.DomainEvents.Interfaces;
using SharedKernel.Notifications.DomainNotifications;
using SharedKernel.Notifications.EmailNotifications;

namespace Infra.CrossCutting.IoC
{
    public class IoCConfig
    {
        public static void ResgisterServices(IServiceCollection services)
        {

            // Application
            services.AddScoped<IHandler<EmailMessage>, EmailMessageHandler>();

            // Domain - Events
            services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Data
            services.AddDbContext<EfContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
