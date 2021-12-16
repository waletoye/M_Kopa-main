using System.Net;

namespace M_Kopa.Sms.App
{
    public record SmsProviderResponse(
        HttpStatusCode HttpStatusCode
    );
}