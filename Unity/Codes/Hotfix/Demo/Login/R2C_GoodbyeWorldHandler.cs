namespace ET
{
    [MessageHandler]
    public class R2C_GoodbyeWorldHandler: AMHandler<R2C_GoodbyeWorld>
    {
        protected override void Run(Session session, R2C_GoodbyeWorld message)
        {
            Log.Debug("消息收到了：" + message.Words);
        }
    }
}