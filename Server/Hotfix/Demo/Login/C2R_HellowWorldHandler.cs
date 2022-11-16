namespace ET
{
    [MessageHandler]
    public class C2R_HellowWorldHandler: AMHandler<C2R_HellowWorld>
    {
        protected override async void Run(Session session, C2R_HellowWorld message)
        {
            Log.Debug(message.Words);
            session.Send(new R2C_GoodbyeWorld() { Words = "你滚吧" });
            await ETTask.CompletedTask;
        }
    }
}