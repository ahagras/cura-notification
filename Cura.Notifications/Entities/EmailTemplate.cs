
namespace Cura.Notifications.Entities
{
    public class EmailTemplate
    {
        public Guid Id { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public EmailTemplate(Guid id, string subject, string body)
        {
            Id = id;
            Subject = subject;
            Body = body;
        }

        public EmailTemplate UpdateSubject(string subject)
        {
            Subject = subject;
            return this;
        }

        public EmailTemplate UpdateBody(string body)
        {
            Body = body;
            return this;
        }
    }
}
