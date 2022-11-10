namespace ET
{
    public class ComputerAwakeSystem: AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("电脑唤醒！");
        }
    }

    public class ComputerUpdateSystem: UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("电脑正在更新！");
        }
    }

    public class ComputerDestroySystem: DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("电脑正在Destroy！");
        }
    }

    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("电脑启动了!!!");
            self.GetComponent<PCBoxComponent>().StartPower();
            self.GetComponent<MonitorComponent>().Display();
        }
    }
}