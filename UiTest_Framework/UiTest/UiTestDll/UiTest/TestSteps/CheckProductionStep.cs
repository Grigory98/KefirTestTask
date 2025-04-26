using System.Collections;
using System.Collections.Generic;
using Assets.UiTest.Context;
using Assets.UiTest.Context.Consts;
using Assets.UiTest.Results;
using Assets.UiTest.TestSteps;
using UiTest.UiTest.Checker;

namespace UiTest.UiTest.TestSteps
{
    class CheckProductionStep : UiTestStepBase
    {
        public override string Id => "check_production_step";
        public override double TimeOut => 300;

        private int seconds;
        private int? amount;
        private bool isWoodPlankEmpty;
        protected override Dictionary<string, string> GetArgs()
        {
            return new Dictionary<string, string>();
        }

        protected override IEnumerator OnRun()
        {
            for (int i = 0; i < seconds; i++)
            {
                CheckWoodIsNotEmpty(seconds);
                if (isWoodPlankEmpty) 
                    CheckWoodPlankIsEmpty(seconds);
                yield return Commands.WaitForSecondsCommand(1, new ResultData<SimpleCommandResult>());
            }
            CheckWoodPlankIsNotEmpty();
        }

        private void CheckWoodIsNotEmpty(int seconds)
        {
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.WorkbenchRow, 0);
            if (countIsEmptyChecker.Check())
            {
                Fail($"The wood shouldn't be disappear less than {seconds} seconds.");
            }
        }

        private void CheckWoodPlankIsEmpty(int seconds)
        {
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.WorkbenchResult, 0);
            if (!countIsEmptyChecker.Check())
            {
                Fail($"The tree has been produced less than {seconds} seconds.");
            }
        }

        private void CheckWoodPlankIsNotEmpty()
        {
            var countIsEmptyChecker = new CountIsEmptyChecker(Context, Screens.Inventory.Cell.WorkbenchResult, 0);
            if (countIsEmptyChecker.Check())
            {
                Fail($"The wood plank hasn't been producted.");
            }

            if (amount != null)
            {
                var cellCountChecker = new CellCountChecker(Context, Screens.Inventory.Cell.WorkbenchResult, 0, (int)amount);
            }
        }

        public CheckProductionStep(int seconds, int? amount, bool isWoodPlankEmpty)
        {
            this.seconds = seconds;
            this.amount = amount;
            this.isWoodPlankEmpty = isWoodPlankEmpty;
        }
    }
}
