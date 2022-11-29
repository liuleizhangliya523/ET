namespace ET
{
    [ActorMessageHandler]
    public class C2M_TestActionLocationMessageHandler: AMActorLocationHandler<Unit, C2M_TestActionLocationMessage>
    {
        protected override async ETTask Run(Unit entity, C2M_TestActionLocationMessage message)
        {
            Log.Debug("服务器收到C2M_TestActionLocationMessage:"+message.Content);
            MessageHelper.SendToClient(entity, new M2C_TestActorMessage(){Content = "sadlkfjldasfjklasdfjkl"});
            await ETTask.CompletedTask;
        }
    }
}