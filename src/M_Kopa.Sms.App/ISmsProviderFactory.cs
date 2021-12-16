namespace M_Kopa.Sms.App
{
    public interface ISmsProviderFactory
    {
        ISmsProvider GetSmsProvider(string phoneNumber);
    }
}