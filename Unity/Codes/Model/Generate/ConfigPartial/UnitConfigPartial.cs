using System.Collections.Generic;
using System.Numerics;

namespace ET
{
    public partial class UnitConfig
    {
        public Vector3 TestVal;
    }

    public class TestVector3
    {
        public Vector3 TestVal;
    }

    public partial class UnitConfigCategory
    {
        public List<TestVector3> TestVector3List = new();

        public override void AfterEndInit()
        {
            base.AfterEndInit();
            foreach (var VARIABLE in this.dict.Values)
            {
                this.TestVector3List.Add(new TestVector3() { TestVal = new Vector3(VARIABLE.Position[0], VARIABLE.Height, VARIABLE.Weight) });
            }
        }

        public UnitConfig GetUnitConfigByHeight(int height)
        {
            UnitConfig config = null;
            foreach (var VARIABLE in this.dict.Values)
            {
                if (VARIABLE.Height == height)
                {
                    config = VARIABLE;
                }
            }

            return config;
        }
    }
}