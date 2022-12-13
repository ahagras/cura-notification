using Cura.Notifications.MessageProviders;

namespace Cura.Notifications.Services
{
    public class NotificationService : INotificationService
    {
        public async Task PushAsync(params MessageProvider[] messageProvider)
        {
            foreach (var msg in messageProvider)
            {
                await msg.SendAsync();
            }
        }
    }
}
