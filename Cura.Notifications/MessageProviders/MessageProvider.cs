using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cura.Notifications.MessageProviders
{
    public abstract class MessageProvider
    {
        protected readonly Guid messageId;
        protected readonly (string, string)[] paramWithValue;

        public MessageProvider(Guid messageId,params (string param, string value)[] paramWithValue)
        {
            this.messageId = messageId;
            this.paramWithValue = paramWithValue;
        }
        internal abstract Task SendAsync();
    }
}
