using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps.InventorySteps
{
    class CheckWoodCountAtInventory : UiTestStepBase
    {
        public override string Id => "check_wood_count_at_inventory";
        public override double TimeOut => 300;

        private int cellIndex;
        private int count;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            yield return CheckWoodCount(cellIndex, count);
        }

        private IEnumerator CheckWoodCount(int cellNumber, int count)
        {
            yield return Commands.UseButtonClickCommand(Screens.Main.Button.Inventory, new ResultData<SimpleCommandResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());

            var cellCountChecker = new CellCountChecker(Context, Screens.Inventory.Cell.Pockets, cellNumber, count);
            if (!cellCountChecker.Check())
            {
                Fail($"Wrong wood count at pockets {cellNumber + 1}th cell");
            }

            yield return Commands.UseButtonClickCommand(Screens.Inventory.Button.Close, new ResultData<SimpleCommandResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
        }

        public CheckWoodCountAtInventory(int cellIndex, int count)
        {
            this.cellIndex = cellIndex;
            this.count = count;
        }
    }
}
