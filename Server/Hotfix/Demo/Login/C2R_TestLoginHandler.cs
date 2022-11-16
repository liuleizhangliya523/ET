using System;

namespace ET
{
    [MessageHandler]
    public class C2R_TestLoginHandler: AMRpcHandler<C2R_TestLogin, R2C_TestLogin>
    {
        protected override async ETTask Run(Session session, C2R_TestLogin request, R2C_TestLogin response, Action reply)
        {
            response.Key = "3.14159263448698943495345";
            reply();
            await ETTask.CompletedTask;
        }
    }
}