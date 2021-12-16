using System.Threading.Tasks;

namespace M_Kopa.Sms.App
{
    public interface IConsumer<IMessage> where IMessage : class
    {
        Task Consume(IMessage message);
    }
}