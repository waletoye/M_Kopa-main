using System;

namespace M_Kopa.Sms.Messages.Models
{
    public record SendSms(
        Guid MessageId,
        Guid ConversationId,
        string PhoneNumber,
        string MessageText
    );
}