using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestSteps.CheatSteps
{
    public class GetWoodPlankStep : UiTestStepBase
    {
        public override string Id => "get_wood_plank_step";
        public override double TimeOut => 300;

        private int amount;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            Cheats.GetWoodPlank(amount);
            return null;
        }

        public GetWoodPlankStep(int amount)
        {
            this.amount = amount;
        }
    }
}
