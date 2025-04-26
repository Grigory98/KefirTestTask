using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestSteps
{
    class GetWoodStep : UiTestStepBase
    {
        public override string Id => "get_wood_step";
        public override double TimeOut => 300;

        private int amount;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            Cheats.GetWood(amount);
            return null;
        }

        public GetWoodStep(int amount)
        {
            this.amount = amount;
        }
    }
}
