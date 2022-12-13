using Cura.Notifications.MessageProviders;

namespace Cura.Notifications.Services
{
    public interface INotificationService
    {
        Task PushAsync(params MessageProvider[] messageProvider);
    }
}
