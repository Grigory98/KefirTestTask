using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestSteps.CheatSteps
{
    public class GetAxeStep : UiTestStepBase
    {
        public override string Id => "get_axe_step";
        public override double TimeOut => 300;
        
        public int amount;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            Cheats.GetAxe(amount);
            return null;
        }

        public GetAxeStep(int amount)
        {
            this.amount = amount;
        }
    }
}
