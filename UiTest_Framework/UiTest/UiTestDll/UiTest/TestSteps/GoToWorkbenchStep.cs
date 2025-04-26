using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps
{
    class GoToWorkbenchStep : UiTestStepBase
    {
        public override string Id => "go_to_workbench_step";
        public override double TimeOut => 300;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            yield return Commands.FindAndGoToSingleObjectCommand(Locations.Home.WorkbenchSawmill, new ResultData<PlayerMoveResult>());
            CheckIsUseButtonActive();
            
            yield return Commands.UseButtonClickCommand(Screens.Main.Button.Use, new ResultData<SimpleCommandResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
        }

        private void CheckIsUseButtonActive()
        {
            var useButtonIsActive = new UseButtonIsActiveChecker(Context);
            if (!useButtonIsActive.Check())
            {
                Fail("Use button is not active");
            }
        }
    }
}
