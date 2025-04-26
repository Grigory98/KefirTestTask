using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestSteps.OtherSteps
{
    class WaitStep : UiTestStepBase
    {
        public override string Id => "wait_step";
        public override double TimeOut => 300;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        private int seconds;

        protected override IEnumerator OnRun()
        {
            yield return Commands.WaitForSecondsCommand(seconds, new ResultData<SimpleCommandResult>());
        }

        public WaitStep(int seconds)
        {
            this.seconds = seconds;
        }
    }
}
