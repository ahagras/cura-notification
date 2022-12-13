using Cura.Notifications.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cura.Notifications
{
    public static class DependencyInjection
    {
        public static void AddCuraNotifications(this IServiceCollection serviceCollection, Action<NotificationOptions> configureOptions)
        {
            serviceCollection.AddTransient<INotificationService, NotificationService>();

            //configureOptions
            // for any configuration form clients
        }
    }
}
