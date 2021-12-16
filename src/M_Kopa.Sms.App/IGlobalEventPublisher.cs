using System.Threading.Tasks;

namespace M_Kopa.Sms.App
{
    public interface IGlobalEventPublisher
    {
        Task Publish<TMessage>(TMessage message) where TMessage : class;
    }
}