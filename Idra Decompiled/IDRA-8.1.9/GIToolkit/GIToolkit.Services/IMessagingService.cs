using CommunityToolkit.Mvvm.Messaging;

namespace GIToolkit.Services;

public interface IMessagingService : IService
{
	void Register<TMessage>(object recipient, MessageHandler<object, TMessage> actionToPerformOnMessage) where TMessage : class;

	void Send<T>(T messageObject) where T : class;
}
