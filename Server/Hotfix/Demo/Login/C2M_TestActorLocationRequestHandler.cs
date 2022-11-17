using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TestActorLocationRequestHandler: AMActorLocationRpcHandler<Unit, C2M_TestActorLocationRequest, M2C_TestActorLocationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TestActorLocationRequest request, M2C_TestActorLocationResponse response, Action reply)
        {
            Log.Debug("服务器收到C2M_TestActorLocationRequest");
            response.Content = "Server已收到C2M_TestActorLocationRequest！";
            reply();
            await ETTask.CompletedTask;
        }
    }
}