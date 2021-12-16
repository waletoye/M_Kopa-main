using System;
using System.Threading.Tasks;

namespace M_Kopa.Sms.App
{
    public interface ISentSmsStore
    {
        Task<bool> HasSentSms(Guid messageMessageId);
        Task RecordSentSms(Guid messageId);
    }
}