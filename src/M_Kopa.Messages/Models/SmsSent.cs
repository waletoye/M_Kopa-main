using System;

namespace M_Kopa.Messages.Models
{
    public record SmsSent(
        Guid MessageId,
        Guid ConversationId,
        string PhoneNumber,
        string MessageText
    );
}