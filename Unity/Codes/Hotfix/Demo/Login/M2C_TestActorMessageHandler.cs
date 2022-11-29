namespace ET
{
    [MessageHandler]
    public class M2C_TestActorMessageHandler: AMHandler<M2C_TestActorMessage>
    {
        protected override async void Run(Session session, M2C_TestActorMessage message)
        {
            Log.Debug("客户端收到M2C_TestActorMessage："+ message.Content);
            await ETTask.CompletedTask;
        }
    }
}