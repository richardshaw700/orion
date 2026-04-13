using CommunityToolkit.Mvvm.Messaging;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class MessagingService : IMessagingService, IService
{
	public MessagingService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}

	public void Send<T>(T messageObject) where T : class
	{
		WeakReferenceMessenger.Default.Send(messageObject);
	}

	public void Register<TMessage>(object recipient, MessageHandler<object, TMessage> actionToPerformOnMessage) where TMessage : class
	{
		WeakReferenceMessenger.Default.Register(recipient, actionToPerformOnMessage);
	}
}
