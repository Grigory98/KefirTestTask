using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;

namespace UiTest.UiTest.TestSteps.InventorySteps
{
    class CloseInventoryStep : UiTestStepBase
    {
        public override string Id => "close_inventory_step";
        public override double TimeOut => 300;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            yield return Commands.UseButtonClickCommand(Screens.Inventory.Button.Close, new ResultData<SimpleCommandResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
        }
    }
}
