using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace ET
{
    public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
    {
        protected override void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();
            var t = new ETCancellationToken();
            Move2P_Async(new Vector3(1, 3, 1), t).Coroutine();
            t.Cancel();
        }

        protected async ETTask Move2P_Async(Vector3 pos, ETCancellationToken t)
        {
            Debug.Log("move start");
            bool ret = await TimerComponent.Instance.WaitAsync(3000, t);
            if (ret)
            {
                Debug.Log("arrived");
            }
            else
            {
                Debug.Log("move cancel");
            }
        }
    }
}