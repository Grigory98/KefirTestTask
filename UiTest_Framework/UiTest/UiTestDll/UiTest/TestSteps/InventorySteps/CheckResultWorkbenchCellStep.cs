using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps.InventorySteps
{
    public class CheckResultWorkbenchCellStep : UiTestStepBase
    {
        public override string Id => "check_workbench_result_cell";
        public override double TimeOut => 300;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            CheckResultCellIsEmpty();
            return null;
        }

        /// <summary>
        /// Checking that object can't be moved to result workbench cell.
        /// </summary>
        private void CheckResultCellIsEmpty()
        {
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.WorkbenchResult, 0);
            if (!countIsEmptyChecker.Check())
            {
                Fail("The object can't be moved to the workbench result cell.");
            }
        }
    }
}
