using Cura.Notifications.Entities;

namespace Cura.Notifications
{
    public static class SeedData
    {
        public static List<EmailTemplate> Messages => new List<EmailTemplate>()
        {
            new EmailTemplate(Guid.Parse("2D3C8D80-774C-4BD9-AAA7-8FB4D37D3615"),"order No ##order_no##","Dear ##full_name## your order ##order_no## is created "),
            new EmailTemplate(Guid.Parse("3F8A7D98-F73D-4D18-92FC-9CBCEF36FD4E"),"invoice no ##invoice_no##","Dear ##full_name## your invoice no ##invoice_no## for your order ##order_no##  ")
        };
    }
}
