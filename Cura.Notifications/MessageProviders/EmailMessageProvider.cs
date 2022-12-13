namespace Cura.Notifications.MessageProviders
{
    public class EmailMessageProvider : MessageProvider
    {
        private readonly string emailAddress;

        public EmailMessageProvider(string emailAddress, Guid messageId,params (string param, string value)[] paramWithValue)
            : base(messageId, paramWithValue)
        {
            this.emailAddress = emailAddress;
        }

        internal override async Task SendAsync()
        {
            var template = SeedData.Messages.FirstOrDefault(_ => _.Id == base.messageId)
                  ?? throw new NotImplementedException();

            foreach (var param in paramWithValue)
            {
              template.UpdateSubject(template.Subject.Replace($"##{param.Item1}##", param.Item2))
                    .UpdateBody(template.Body.Replace($"##{param.Item1}##", param.Item2));
            }

            await Task.CompletedTask;
        }
    }
}
