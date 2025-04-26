using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps.InventorySteps
{
    class MoveObjectStep : UiTestStepBase
    {
        public override string Id => "move_object_step";
        public override double TimeOut => 300;

        private StringParam inventoryIdStart;
        private int cellNumberStart;
        private int cellNumberEnd;
        private StringParam cell;
        private int count;

        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            yield return Commands.DragAndDropCommand(inventoryIdStart, cellNumberStart, cell, cellNumberEnd, new ResultData<SimpleCommandResult>());
            yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
            var cellCountChecker = new CellCountChecker(Context, cell, cellNumberEnd, count);
            if (!cellCountChecker.Check())
            {
                Fail($"Wrong count item at cell {cellNumberEnd}");
            }
        }

        public MoveObjectStep(StringParam inventoryIdStart, int cellNumberStart, int cellNumberEnd, StringParam cell, int count)
        {
            this.inventoryIdStart = inventoryIdStart;
            this.cellNumberStart = cellNumberStart;
            this.cellNumberEnd = cellNumberEnd;
            this.cell = cell;
            this.count = count;
        }
    }
}
