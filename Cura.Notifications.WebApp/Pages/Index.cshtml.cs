using Cura.Notifications.MessageProviders;
using Cura.Notifications.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cura.Notifications.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly INotificationService notificationService;

        public IndexModel(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public async Task OnGet()
        {
            var msg = new EmailMessageProvider("test@test.com", Guid.Parse("2D3C8D80-774C-4BD9-AAA7-8FB4D37D3615"),
                ("order_no", "123"),
                ("full_name", "Mphamed Abdallah"));

            var msg2 = new EmailMessageProvider("test@test.com", Guid.Parse("3F8A7D98-F73D-4D18-92FC-9CBCEF36FD4E"),
                ("full_name", "ahmed mohamed"),
                ("order_no", "645"),
                ("invoice_no", "8798"));


            var msg3 = new EmailMessageProvider("test2@test.com", Guid.Parse("3F8A7D98-F73D-4D18-92FC-9CBCEF36FD4E"),
                ("full_name", "Omar khatab"),
                ("order_no", "99875"),
                ("invoice_no", "1242"));

            await notificationService.PushAsync(msg, msg2, msg3);
        }
    }
}