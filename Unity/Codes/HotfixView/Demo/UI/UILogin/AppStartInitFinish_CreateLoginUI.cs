namespace ET
{
    public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
    {
        protected override void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();
            // Test(args.ZoneScene).Coroutine();
            Computer computer = args.ZoneScene.AddChild<Computer>();
            Game.EventSystem.Publish(new EventType.InstallComputer() { computer = computer });
        }

        // public async ETTask Test(Scene zoneScene)
        // {
        //     Computer computer = zoneScene.AddChild<Computer>();
        //
        //     computer.AddComponent<PCBoxComponent>();
        //     computer.AddComponent<MonitorComponent>();
        //     computer.AddComponent<KeyboardComponent>();
        //     computer.AddComponent<MouseComponent>();
        //
        //     computer.Start();
        //     await TimerComponent.Instance.WaitAsync(3000);
        //     computer.Dispose();
        //
        //     UnitConfig config = UnitConfigCategory.Instance.Get(1001);
        //
        //     Log.Debug(config.Name);
        //
        //     var allConfigData = UnitConfigCategory.Instance.GetAll();
        //     foreach (var VARIABLE in allConfigData)
        //     {
        //         Log.Debug(VARIABLE.Value.Name);
        //         Log.Debug("Position: " + string.Join(", ", VARIABLE.Value.Position));
        //     }
        //
        //     UnitConfig heightConfig = UnitConfigCategory.Instance.GetUnitConfigByHeight(180);
        //     Log.Debug("The 180 height person's name is " + heightConfig.Name);
        //
        //     foreach (var VARIABLE in UnitConfigCategory.Instance.TestVector3List)
        //     {
        //         Log.Debug(VARIABLE.TestVal.ToString());
        //     }
        // }
    }
}