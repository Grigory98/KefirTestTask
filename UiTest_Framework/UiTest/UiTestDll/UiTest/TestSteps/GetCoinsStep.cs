using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestSteps
{
    class GetCoinsStep : UiTestStepBase
    {
        public override string Id => "get_coins_step";
        public override double TimeOut => 300;

        private int amount;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            Cheats.GetCoins(amount);
            return null;
        }

        public GetCoinsStep(int amount)
        {
            this.amount = amount;
        }
    }
}
