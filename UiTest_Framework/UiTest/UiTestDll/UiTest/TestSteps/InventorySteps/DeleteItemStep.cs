using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps.InventorySteps
{
    class DeleteItemStep : UiTestStepBase
    {
        public override string Id => "delete_item_inventory_step";
        public override double TimeOut => 300;

        public int cellIndex;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            Context.Inventory.GetCells(Screens.Inventory.Cell.Pockets.Item).ClickCell(cellIndex);
            yield return Commands.UseButtonClickCommand(Screens.Inventory.Button.Delete, new ResultData<SimpleCommandResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
            
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.Pockets, cellIndex);
            if (!countIsEmptyChecker.Check())
            {
                Fail($"The object hasn't been deleted in cell {cellIndex}");
            }
        }

        public DeleteItemStep(int cellIndex)
        {
            this.cellIndex = cellIndex;
        }
    }   
}
