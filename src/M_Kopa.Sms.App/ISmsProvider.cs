using System.Threading.Tasks;

namespace M_Kopa.Sms.App
{
    public interface ISmsProvider
    {
        Task<SmsProviderResponse> SendSms(string phoneNumber, string messageText);
    }
}